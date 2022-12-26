namespace ReadExcelApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDemoDataSet = new ReadExcelApp.dbDemoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.dbDemoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoTableAdapter1 = new ReadExcelApp.dbDemoDataSetTableAdapters.demoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDemoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(669, 359);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(81, 361);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(580, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(81, 389);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 2;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // demoBindingSource
            // 
            this.demoBindingSource.DataMember = "demo";
            this.demoBindingSource.DataSource = this.dbDemoDataSet;
            // 
            // dbDemoDataSet
            // 
            this.dbDemoDataSet.DataSetName = "dbDemoDataSet";
            this.dbDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet  :  ";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(218, 389);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(78, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dbDemoDataSetBindingSource
            // 
            this.dbDemoDataSetBindingSource.DataSource = this.dbDemoDataSet;
            this.dbDemoDataSetBindingSource.Position = 0;
            // 
            // demoTableAdapter1
            // 
            this.demoTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 432);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Excel To SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDemoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private dbDemoDataSetTableAdapters.demoTableAdapter demoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKKODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARKODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATURANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAĞAZAKODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAĞAZAADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mİKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATIŞSORUMLUSUKODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATIŞSORUMLUSUADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fİYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSKONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETBİRİMFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETTUTARIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öDEMETİPİDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öDEMEAÇIKLAMASIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.BindingSource dbDemoDataSetBindingSource;
        private dbDemoDataSet dbDemoDataSet;
        private dbDemoDataSetTableAdapters.demoTableAdapter demoTableAdapter1;
        public System.Windows.Forms.BindingSource demoBindingSource;
        //      private dbDemoDataSet1TableAdapters.demoTableAdapter demoTableAdapter;
    }
}

