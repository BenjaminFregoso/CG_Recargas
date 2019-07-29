using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Threading;

namespace CasaGuerrero
{
    public partial class Principal : Form
    {
        


        int elec;
        public Principal()
        {
            InitializeComponent();
        }
    
        //ACCIONES QUE REALIZA AL PULSAR LAS TECLAS F1, F2, F3, F4, F5, F6, F7, F8, F9, F10 Y ESC********************************
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if ((keyData != Keys.F1) & (keyData != Keys.F2) & (keyData != Keys.F3) & (keyData != Keys.F4)
                & (keyData != Keys.F5) & (keyData != Keys.F6) & (keyData != Keys.F7) & (keyData != Keys.F8)
                 & (keyData != Keys.F9) & (keyData != Keys.F10) & (keyData != Keys.F11) & (keyData != Keys.F12)
                  & (keyData != Keys.Alt + 1) & (keyData != Keys.Escape))
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.F1) { btnTelcel.PerformClick(); }
            if (keyData == Keys.F4) { btnVirginMobile.PerformClick(); }
            if (keyData == Keys.F6) { btnNextel.PerformClick(); }
            if (keyData == Keys.F5) { btnUnefon.PerformClick(); }
            if (keyData == Keys.F7) { btnAlo.PerformClick(); }
            if (keyData == Keys.F2) { btnMovistar.PerformClick(); }
            if (keyData == Keys.F3) { btnAtYtIusacell.PerformClick(); }
            if (keyData == Keys.F10) { btnConsulta.PerformClick(); }
            if (keyData == Keys.F11) { btnAyuda.PerformClick(); }
            if (keyData == Keys.F12) { btnAdmin.PerformClick(); }
            if (keyData == Keys.Escape) { Close(); }
            return true;
        }

        //Abrir solo 1
       
        private static bool FirstInstance
        {
            get
            {
                bool created;
                string name = Assembly.GetEntryAssembly().FullName;
                // created will be True if the current thread creates and owns the mutex.
                // Otherwise created will be False if a previous instance already exists.
                Mutex mutex = new Mutex(true, name, out created);
                return created;
            }
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(221, 221, 221),
                                                                       Color.FromArgb(0, 45, 45),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void btnTelcel_Click(object sender, EventArgs e)
        {
            elec = 7;

            /*
            Recarga form = new Recarga(elec);
            form.Show();
            */
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnVirginMobile_Click(object sender, EventArgs e)
        {
            elec = 1;
            /*
            Recarga form = new Recarga(elec);
            form.Show();
            */
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnAlo_Click(object sender, EventArgs e)
        {
            elec = 2;
            /*
            Recarga form = new Recarga(elec);
            form.Show();
            */

            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnMovistar_Click(object sender, EventArgs e)
        {
            elec = 3;
            /*
             
            Recarga form = new Recarga(elec);
            form.Show();
            */

            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnUnefon_Click(object sender, EventArgs e)
        {
            elec = 4;
            /*
            Recarga form = new Recarga(elec);
            form.Show();
            */
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnAtYtIusacell_Click(object sender, EventArgs e)
        {
            elec = 5;
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        private void btnNextel_Click(object sender, EventArgs e)
        {
            elec = 6;
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                new Recarga(elec).ShowDialog();
            }
            else
            {
                MessageBox.Show("NO ESTA PERMITIDO HACER 2 RECARGAS EN UNA MISMA VENTA");
                Application.Exit();
            }
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaRecargas form = new ConsultaRecargas();
            form.Show();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrador form = new Administrador();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = Path.Combine(Application.StartupPath, "ManualCajero.pdf");
            proc.Start();
            proc.Close();
            Environment.Exit(1);
        }

        private void btnAyuda_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = Path.Combine(Application.StartupPath, "ManualCajero.pdf");
            proc.Start();
            proc.Close();
            Environment.Exit(1);
        }
    }
}
