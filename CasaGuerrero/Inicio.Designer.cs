namespace CasaGuerrero
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagoServicio = new System.Windows.Forms.Button();
            this.btnRecargas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECARGAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PAGO DE SERVICIOS";
            this.label2.Visible = false;
            // 
            // btnPagoServicio
            // 
            this.btnPagoServicio.BackgroundImage = global::CasaGuerrero.Properties.Resources.PAGO_SERVICIOS;
            this.btnPagoServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagoServicio.Location = new System.Drawing.Point(267, 34);
            this.btnPagoServicio.Name = "btnPagoServicio";
            this.btnPagoServicio.Size = new System.Drawing.Size(200, 120);
            this.btnPagoServicio.TabIndex = 1;
            this.btnPagoServicio.UseVisualStyleBackColor = true;
            this.btnPagoServicio.Visible = false;
            this.btnPagoServicio.Click += new System.EventHandler(this.BtnPagoServicio_Click);
            // 
            // btnRecargas
            // 
            this.btnRecargas.BackgroundImage = global::CasaGuerrero.Properties.Resources.RECARGAS;
            this.btnRecargas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargas.Location = new System.Drawing.Point(141, 34);
            this.btnRecargas.Name = "btnRecargas";
            this.btnRecargas.Size = new System.Drawing.Size(200, 120);
            this.btnRecargas.TabIndex = 0;
            this.btnRecargas.UseVisualStyleBackColor = true;
            this.btnRecargas.Click += new System.EventHandler(this.BtnRecargas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagoServicio);
            this.Controls.Add(this.btnRecargas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGOS";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecargas;
        private System.Windows.Forms.Button btnPagoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}