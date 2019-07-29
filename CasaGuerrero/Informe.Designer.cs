namespace CasaGuerrero
{
    partial class Informe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe));
            this.RecargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recargasDataSet = new CasaGuerrero.recargasDataSet();
            this.GeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RecargaTableAdapter = new CasaGuerrero.recargasDataSetTableAdapters.RecargaTableAdapter();
            this.GeneralTableAdapter = new CasaGuerrero.recargasDataSetTableAdapters.GeneralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RecargaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recargasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecargaBindingSource
            // 
            this.RecargaBindingSource.DataMember = "Recarga";
            this.RecargaBindingSource.DataSource = this.recargasDataSet;
            // 
            // recargasDataSet
            // 
            this.recargasDataSet.DataSetName = "recargasDataSet";
            this.recargasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GeneralBindingSource
            // 
            this.GeneralBindingSource.DataMember = "General";
            this.GeneralBindingSource.DataSource = this.recargasDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Recarga";
            reportDataSource1.Value = this.RecargaBindingSource;
            reportDataSource2.Name = "General";
            reportDataSource2.Value = this.GeneralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CasaGuerrero.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // RecargaTableAdapter
            // 
            this.RecargaTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralTableAdapter
            // 
            this.GeneralTableAdapter.ClearBeforeFill = true;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Informe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecargaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recargasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RecargaBindingSource;
        private recargasDataSet recargasDataSet;
        private recargasDataSetTableAdapters.RecargaTableAdapter RecargaTableAdapter;
        private System.Windows.Forms.BindingSource GeneralBindingSource;
        private recargasDataSetTableAdapters.GeneralTableAdapter GeneralTableAdapter;
    }
}