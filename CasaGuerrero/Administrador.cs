using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaGuerrero
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void generalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recargasDataSet);

        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData != Keys.Escape)
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Escape) { Close(); }
            return true;
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
        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.General' Puede moverla o quitarla según sea necesario.
            this.generalTableAdapter.Fill(this.recargasDataSet.General);
            txtPass.PasswordChar = '*';
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //CONTRASENA VENTANA ADMINISTRADOR *****************************************************************************************
            if (txtUsuario.Text == "Admin" && txtPass.Text== "Admingdl-01")
            {
                generalBindingNavigatorSaveItem.Visible = true;
                generalDataGridView.Visible = true;
            }
        }

        private void generalBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.generalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recargasDataSet);

        }

        private void generalBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.generalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recargasDataSet);

        }
    }
}
