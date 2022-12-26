using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace ReadExcelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verileri almak istedigimiz tablo adini belirttik ve ardindan verileri datagridview e bagladik
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];

            dataGridView1.DataSource = dt;

            if (dt != null)
            {
                List<Satis> satiss = new List<Satis>();

                //for (int i = 0; i < dt.Rows.Count; i++)
                foreach (DataRow row in dt.Rows)
                {
                    Satis satis1 = new Satis();

                    //satis1.DemoId = row["DemoId"].ToString();

                    satis1.TARİH = row["TARİH"].ToString();

                    satis1.STOKKODU = row["STOKKODU"].ToString();

                    satis1.STOKADI = row["STOKADI"].ToString();

                    satis1.RENK = row["RENK"].ToString();

                    satis1.BEDEN = row["BEDEN"].ToString();

                    satis1.BARKOD = row["BARKOD"].ToString();

                    satis1.FATURANO = row["FATURANO"].ToString();

                    satis1.MAĞAZAKODU = row["MAĞAZAKODU"].ToString();

                    satis1.MAĞAZAADI = row["MAĞAZAADI"].ToString();

                    satis1.MİKTAR = row["MİKTAR"].ToString();

                    satis1.SATIŞSORUMLUSUKODU = row["SATIŞSORUMLUSUKODU"].ToString();

                    satis1.SATIŞSORUMLUSUADI = row["SATIŞSORUMLUSUADI"].ToString();

                    satis1.KDV = row["KDV"].ToString();

                    satis1.FİYAT = row["FİYAT"].ToString();

                    satis1.TUTAR = row["TUTAR"].ToString();

                    satis1.İSKONTO = row["İSKONTO"].ToString();

                    satis1.NETBİRİMFİYAT = row["NETBİRİMFİYAT"].ToString();

                    satis1.NETTUTAR = row["NETTUTAR"].ToString();

                    satis1.ÖDEMETİPİ = row["ÖDEMETİPİ"].ToString();

                    satis1.ÖDEMEAÇIKLAMASI = row["ÖDEMEAÇIKLAMASI"].ToString();

                    satiss.Add(satis1);
                }
                demoBindingSource.DataSource = satiss;

            }
        }

        DataTableCollection tableCollection;
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //excel dosyasini okumak icin excelreaderfactory sinifinin createreader yontemini kullan. Excel dosyasindan okudugumuz veriler dataset olarak dondurulecektir.
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach(DataTable table in tableCollection)
                            {
                                cboSheet.Items.Add(table.TableName); //combobox a sayfalari ekledik.
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        { 
            //nuget paketlerinden dapper plus i yuklememiz gerekir.
            try
            {
                string connectionString = "Server=DESKTOP-8LLIB44\\USERB; Database=dbDemo;User Id = sa; Password = 1234";
                DapperPlusManager.Entity<Satis>().Table("dbo.demo");
                List<Satis> satis7 = demoBindingSource.DataSource as List<Satis>;

              
                    using(IDbConnection db = new SqlConnection(connectionString))
                    {                        
                        db.BulkInsert(satis7);
                    }
                
                MessageBox.Show("Finish !!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'dbDemoDataSet.demo' table. You can move, or remove it, as needed.
        //    this.demoTableAdapter1.Fill(this.dbDemoDataSet.demo);

        //}
    }
}
