using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace CasaGuerrero
{
    public partial class ConsultaRecargas : Form
    {
        string cr;
        string producto;
        Metodos serv = new Metodos();
        //string no_transaccion, codeX;
        string transaccion_rec;
        //Datos consulta
        int transaccion_0, transaccion_con, cadena_5, establecimiento_6, terminal_7;
        private ComboBox comboInstalledPrinters = new ComboBox();
        private PrintDocument printDoc = new PrintDocument();

        string code;
        string telefono_1, sku_2, fecha_hora_3, fecha_hora_con, cve_estado_4, cajero_8, clave_9,monto, descripcion, num_autorizacion;
        string producto_aux, montoSinPuntos, almacen;
        string ruta;
        string[] args = Environment.GetCommandLineArgs();
        string ID_Archivo, ID_Cadena, ID_Establecimiento, ID_Terminal, ID_Cajero, ID_clave, Estado, Direccion, Ciudad, Ruta_Serv, Ruta_ftp, User_ftp, Pass_ftp;

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = recargaDataGridView.SelectedRows;
            transaccion_rec = row[0].Cells[0].Value.ToString();
            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lector;

            cmd.CommandText = "Select * from Recarga where no_transaccion ='" + transaccion_rec + "'";
            lector = cmd.ExecuteReader();
            try
            {
                //NUEVOS DATOS PARA EL TICKET**************************************************************************************************

                if (lector.HasRows)
                {
                    lector.Read();

                    transaccion_0 = lector.GetInt32(0);
                    telefono_1 = lector.GetString(1);
                    sku_2 = lector.GetString(2);
                    fecha_hora_3 = lector.GetString(3);
                    cve_estado_4 = lector.GetString(4);
                    cadena_5 = lector.GetInt32(5);
                    establecimiento_6 = lector.GetInt32(6);
                    terminal_7 = lector.GetInt32(7);
                    cajero_8 = lector.GetString(8);
                    clave_9 = lector.GetString(9);
                    cr = lector.GetString(10);
                    
                    producto = lector.GetString(12);
                    num_autorizacion = lector.GetString(15);
                    if (cr == "0")
                    {

                        decimal montoo;
                        montoo = lector.GetDecimal(14);

                        monto = montoo.ToString("0.00");

                        //MessageBox.Show("Monto decimal: " + montoo);

                        //MessageBox.Show("Monto string: " + monto);

                        producto_aux = producto;


                        if (producto_aux.Length > 13)
                        {
                            producto_aux = producto_aux.Substring(0, 13);
                        }
                        CrearTicket ticket = new CrearTicket();
                        //verificar almacen
                        string sucursal = args[1].Substring(4, 2);

                        if (sucursal == "01" || sucursal == "02" || sucursal == "03" || sucursal == "04" || sucursal == "05" || sucursal == "13" || sucursal == "14" || sucursal == "15" || sucursal == "19" || sucursal == "20")
                        {
                            almacen = "01";//GUADALAJARA
                        }
                        else if (sucursal == "06" || sucursal == "07" || sucursal == "08" || sucursal == "09")
                        {
                            almacen = "02";//ATEQUIZA
                        }
                        else if (sucursal == "10" || sucursal == "11" || sucursal == "12")
                        {
                            almacen = "03"; //IXTLAHUACAN
                        }
                        else if (sucursal == "21" || sucursal == "22" || sucursal == "23" || sucursal == "24" || sucursal == "25" || sucursal == "26" || sucursal == "27" || sucursal == "28" || sucursal == "29")
                        {
                            almacen = "04"; //TLAJOMULCO
                        }
                       
                        
                        //ticket.TextoIzquierda(" ");
                        ticket.TextoCentro("********* RECARGA TAE *********");
                        ticket.TextoIzquierda(" ");
                        ticket.TextoCentro("CASA GUERRERO DEPARTAMENTAL");
                        ticket.TextoCentro("COMERCIAL DE RETIRO S.A. DE C.V.");
                        ticket.TextoCentro("" + Direccion);
                        ticket.TextoCentro("" + Ciudad);
                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda("Almacen:      " + almacen);
                        ticket.TextoIzquierda("Folio:        " + args[1]);
                        ticket.TextoIzquierda("Fecha:        " + fecha_hora_3.Substring(0, 10));
                        ticket.TextoIzquierda("Hora:         " + fecha_hora_3.Substring(11, 8));
                        ticket.TextoIzquierda("Vendedor:     CAJA " + args[1].Substring(4, 2));
                        ticket.TextoIzquierda(" ");
                        //ticket.TextoExtremos("FECHA : " + fecha_hora_3.Substring(0, 10), "HORA : " + fecha_hora_3.Substring(10, 9));
                        ticket.TextoIzquierda(" ");
                        ticket.EncabezadoVenta();
                        ticket.lineasGuio();
                        if (cr != "0")
                        {

                            ticket.AgregaArticulo(producto_aux + " " + telefono_1, 0, montoo);
                        }
                        else
                        {
                            ticket.AgregaArticulo(producto_aux + " " + telefono_1, 1, montoo);
                        }

                        ticket.lineasIgual();
                        if (cr != "0")
                        {

                            ticket.TextoIzquierda("              TOTAL : $           0.00");
                        }
                        else
                        {
                            ticket.AgregarTotales("              TOTAL : $", montoo);
                        }

                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda("Transaccion               " + transaccion_0.ToString());
                        ticket.TextoIzquierda("Autorizacion              " + num_autorizacion);
                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda(" ");
                        ticket.lineasIgual();
                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda(" ");

                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda(" ");
                        ticket.TextoIzquierda(" ");
                        ticket.CortaTicket();

                        

                        // Revisar impresoras instaladas
                        int i;
                        string pkInstalledPrinters;
                        string impresora ="";
                        for (i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                        {
                            pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                            if (printDoc.PrinterSettings.IsDefaultPrinter)
                            {
                                impresora = printDoc.PrinterSettings.PrinterName;
                            }
                        }



                        ticket.ImprimirTicket(""+impresora);
                        
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUEDE IMPRIMIR UN TICKET DE UNA RECARGA QUE NO SE REALIZÓ", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                lector.Close();
                cn.Close();
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltroReporte form = new FiltroReporte();
            form.Show();
        }

        String yyyymmdd = "", dia, mes;

        private void recargaDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {

                    DataGridViewSelectedRowCollection row = recargaDataGridView.SelectedRows;
                    //Aqui se obtiene la fila seleccionada.
                    
                   // monto = recargaDataGridView.GetCellCount(DataGridViewElementStates.Selected).ToString();
                    //MessageBox.Show("Transaccion: "+monto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public ConsultaRecargas()
        {
            InitializeComponent();
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
                                                                       Color.FromArgb(0, 61, 61),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void DatosGenneral()
        {
            //CARGAR DATOS GENERAL********************************************************************************************************
            try
            {
                generalDataGridView.Rows[0].Selected = true;
                DataGridViewSelectedRowCollection row = generalDataGridView.SelectedRows;
                //Aqui se obtiene la fila seleccionada.



                ID_Archivo = row[0].Cells[0].Value.ToString();
                ID_Cadena = row[0].Cells[1].Value.ToString();
                ID_Establecimiento = row[0].Cells[2].Value.ToString();
                ID_Terminal = row[0].Cells[3].Value.ToString();
                ID_Cajero = row[0].Cells[4].Value.ToString();
                ID_clave = row[0].Cells[5].Value.ToString();
                Estado = row[0].Cells[6].Value.ToString();
                Direccion = row[0].Cells[7].Value.ToString();
                Ciudad = row[0].Cells[8].Value.ToString();
                Ruta_ftp = row[0].Cells[9].Value.ToString();
                Ruta_Serv = row[0].Cells[10].Value.ToString();
                User_ftp = row[0].Cells[11].Value.ToString();
                Pass_ftp = row[0].Cells[12].Value.ToString();

                //MessageBox.Show(""+Direccion+" "+Ciudad+" "+Ruta_Serv+ " "+ Ruta_ftp+" "+User_ftp+" "+Pass_ftp+" ");
                //MessageBox.Show("Datos: " + ID_Archivo + ID_Cadena + ID_Establecimiento + ID_Terminal + ID_Cajero + ID_clave + Estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ConsultaRecargas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.General' Puede moverla o quitarla según sea necesario.
            this.generalTableAdapter.Fill(this.recargasDataSet.General);


            DatosGenneral();
            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.Recarga' Puede moverla o quitarla según sea necesario.
            this.recargaTableAdapter.FillByConsultas(this.recargasDataSet.Recarga);

            

            //CARGAR DATOS TABLA GENERAL ********************************************************************************
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            

            string fech = dateTimePicker1.Text;
            recargaBindingSource.Filter = " fecha = '" + fech + "'";
            dateTimePicker1.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            //FTP
            

            dia = DateTime.Today.Day.ToString();//obtenemos el dia
            mes = DateTime.Today.Month.ToString();//obtenemos el mes
            if (dia.Length == 1) { dia = "0" + dia; }//si la cantidad de caracteres del dia es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados
            if (mes.Length == 1) { mes = "0" + mes; }//si la cantidad de caracteres del mes es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados

            //*********CREAR LA CARPETA Y EL ARCHIVO .TXT***********
            yyyymmdd = DateTime.Today.Year.ToString() + mes + dia; //obtenemos el año mes y dia
                                                                   //De tabla

            //ruta = @""+Ruta_Serv+ID_Archivo + ID_Cadena + ID_Establecimiento + yyyymmdd + ".txt";//creamos la ruta
            ruta = @"" + Ruta_Serv + ID_Archivo + "0" + ID_Cadena + "0" + ID_Establecimiento + yyyymmdd + ".txt";
            if (File.Exists(ruta) == false)
            {
                using (var fileStream = File.Create(ruta))
                {
                    fileStream.Flush();
                }
            }

            foreach (DataGridViewRow vFila in recargaDataGridView.Rows)
            {
                string tempo = vFila.Cells[10].Value.ToString();
                if (tempo == "")
                {
                    vFila.Cells[0].Style.BackColor = Color.Green;
                    vFila.Cells[1].Style.BackColor = Color.Green;
                    vFila.Cells[3].Style.BackColor = Color.Green;
                    vFila.Cells[10].Style.BackColor = Color.Green;
                    vFila.Cells[11].Style.BackColor = Color.Green;
                    vFila.Cells[12].Style.BackColor = Color.Green;
                    vFila.Cells[13].Style.BackColor = Color.Green;
                    vFila.Cells[15].Style.BackColor = Color.Green;
                }
                else if (tempo != "0")
                {
                    vFila.Cells[0].Style.BackColor = Color.IndianRed;
                    vFila.Cells[1].Style.BackColor = Color.IndianRed;
                    vFila.Cells[3].Style.BackColor = Color.IndianRed;
                    vFila.Cells[10].Style.BackColor = Color.IndianRed;
                    vFila.Cells[11].Style.BackColor = Color.IndianRed;
                    vFila.Cells[12].Style.BackColor = Color.IndianRed;
                    vFila.Cells[13].Style.BackColor = Color.IndianRed;
                    vFila.Cells[15].Style.BackColor = Color.IndianRed;
                }

            }

        }




        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void recargaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recargaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recargasDataSet);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            string fech = dateTimePicker1.Text;
            //MessageBox.Show("Es:" + fech);
            recargaBindingSource.Filter = " fecha = '" + fech + "'";
            dateTimePicker1.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            foreach (DataGridViewRow vFila in recargaDataGridView.Rows)
            {
                string tempo = vFila.Cells[10].Value.ToString();
                if (tempo == "")
                {
                    vFila.Cells[0].Style.BackColor = Color.Green;
                    vFila.Cells[1].Style.BackColor = Color.Green;
                    vFila.Cells[3].Style.BackColor = Color.Green;
                    vFila.Cells[10].Style.BackColor = Color.Green;
                    vFila.Cells[11].Style.BackColor = Color.Green;
                    vFila.Cells[12].Style.BackColor = Color.Green;
                    vFila.Cells[13].Style.BackColor = Color.Green;
                    vFila.Cells[15].Style.BackColor = Color.Green;
                }
                else if (tempo != "0")
                {
                    vFila.Cells[0].Style.BackColor = Color.IndianRed;
                    vFila.Cells[1].Style.BackColor = Color.IndianRed;
                    vFila.Cells[3].Style.BackColor = Color.IndianRed;
                    vFila.Cells[10].Style.BackColor = Color.IndianRed;
                    vFila.Cells[11].Style.BackColor = Color.IndianRed;
                    vFila.Cells[12].Style.BackColor = Color.IndianRed;
                    vFila.Cells[13].Style.BackColor = Color.IndianRed;
                    vFila.Cells[15].Style.BackColor = Color.IndianRed;
                }

            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            string fech = dateTimePicker1.Text;
            //MessageBox.Show("Es:" + fech);
            recargaBindingSource.Filter = " fecha = '" + fech + "'";
            dateTimePicker1.CustomFormat = "dddd dd ' de' MMMM 'del ' yyyy";

            foreach (DataGridViewRow vFila in recargaDataGridView.Rows)
            {
                string tempo = vFila.Cells[10].Value.ToString();
                if (tempo == "")
                {
                    vFila.Cells[0].Style.BackColor = Color.Green;
                    vFila.Cells[1].Style.BackColor = Color.Green;
                    vFila.Cells[3].Style.BackColor = Color.Green;
                    vFila.Cells[10].Style.BackColor = Color.Green;
                    vFila.Cells[11].Style.BackColor = Color.Green;
                    vFila.Cells[12].Style.BackColor = Color.Green;
                    vFila.Cells[13].Style.BackColor = Color.Green;
                    vFila.Cells[15].Style.BackColor = Color.Green;
                }
                else if (tempo != "0")
                {
                    vFila.Cells[0].Style.BackColor = Color.IndianRed;
                    vFila.Cells[1].Style.BackColor = Color.IndianRed;
                    vFila.Cells[3].Style.BackColor = Color.IndianRed;
                    vFila.Cells[10].Style.BackColor = Color.IndianRed;
                    vFila.Cells[11].Style.BackColor = Color.IndianRed;
                    vFila.Cells[12].Style.BackColor = Color.IndianRed;
                    vFila.Cells[13].Style.BackColor = Color.IndianRed;
                    vFila.Cells[15].Style.BackColor = Color.IndianRed;
                }

            }
        }

        private void recargaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.recargaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recargasDataSet);

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            

            
            DataGridViewSelectedRowCollection row = recargaDataGridView.SelectedRows;

            if (row[0].Cells[10].Value.ToString() != "")
            {
                MessageBox.Show("SU RECARGA YA TIENE CÓDIGO DE RESPUESTA", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                transaccion_rec = row[0].Cells[0].Value.ToString();
                //MessageBox.Show("Numero es: " + transaccion_rec);
                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                SqlDataReader lector2;


                string fecha = serv.Getfecha(DateTime.Now.ToString("ddMMyyyy HHmmss"));
                cmd.CommandText = "insert into Consulta values('" + transaccion_rec + "', '" + fecha + "','')";
                cmd.ExecuteNonQuery();

                //HACER CONSULTA

                String producto, instruccion1, instruccion2;

                try
                {
                    //creamos los objetos para el WEB SERVICE
                    WSMTCenter.ServiceSoapClient ws = new WSMTCenter.ServiceSoapClient();
                    WSMTCenter.recargaRequestBody peticion = new WSMTCenter.recargaRequestBody();
                    WSMTCenter.recargaResponseBody respuesta = new WSMTCenter.recargaResponseBody();

                    WSMTCenter.InputConsulta inputConsulta = new WSMTCenter.InputConsulta();
                    WSMTCenter.OutputConsulta outputConsulta = new WSMTCenter.OutputConsulta();
                    WSMTCenter.Cuenta cuenta = new WSMTCenter.Cuenta();


                    cmd.CommandText = "Select * from Recarga where no_transaccion ='" + transaccion_rec + "'";
                    lector = cmd.ExecuteReader();

                    if (lector.HasRows)
                    {
                        lector.Read();

                        transaccion_0 = lector.GetInt32(0);
                        telefono_1 = lector.GetString(1);
                        sku_2 = lector.GetString(2);
                        fecha_hora_3 = lector.GetString(3);
                        cve_estado_4 = lector.GetString(4);
                        cadena_5 = lector.GetInt32(5);
                        establecimiento_6 = lector.GetInt32(6);
                        terminal_7 = lector.GetInt32(7);
                        cajero_8 = lector.GetString(8);
                        clave_9 = lector.GetString(9);
                        producto = lector.GetString(12);
                        cuenta.cadena = cadena_5;
                        cuenta.establecimiento = establecimiento_6;
                        cuenta.terminal = terminal_7;
                        cuenta.cajero = cajero_8;
                        cuenta.clave = clave_9;
                        inputConsulta.cuenta = cuenta;

                        inputConsulta.no_transaccion_recarga = transaccion_0;
                        inputConsulta.telefono = telefono_1;
                        inputConsulta.sku = sku_2;
                        inputConsulta.fecha_hora_recarga = fecha_hora_3;
                        lector.Close();
                        // CAMBIAR POR  WHERE NO_TRANSACCION_REC || HECHO 02/04/2019
                        cmd.CommandText = "Select * from Consulta where no_transaccion_rec ='" + transaccion_rec + "'";
                        lector2 = cmd.ExecuteReader();
                        if (lector2.HasRows)
                        {
                            lector2.Read();
                            transaccion_con = lector2.GetInt32(0);
                            fecha_hora_con = lector2.GetString(2);
                            inputConsulta.no_transaccion = transaccion_con;
                            inputConsulta.fecha_hora = fecha_hora_con;
                        }
                        lector2.Close();
                        outputConsulta = ws.consulta(inputConsulta);

                        cr = outputConsulta.codigo_respuesta.ToString();
                        descripcion = outputConsulta.descripcion_respuesta.ToString();
                        num_autorizacion = outputConsulta.no_autorizacion.ToString();

                        Cursor.Current = Cursors.Default;
                        cmd.CommandText = "update Consulta set no_autorizacion = '" + num_autorizacion + "' where no_transaccion_rec ='" + transaccion_rec + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "update Recarga set code = '" + cr + "', no_autorizacion = '" + num_autorizacion + "', descripcion = '" + descripcion + "' where no_transaccion ='" + transaccion_rec + "'";
                        cmd.ExecuteNonQuery();

                        if (cr == "0")
                        {
                            MessageBox.Show("RECARGA EXITOSA " + Environment.NewLine + "CÓDIGO DE RESPUESTA: " + cr, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else
                        {
                            MessageBox.Show("LA RECARGA NO SE REALIZÓ" + Environment.NewLine + "CÓDIGO DE RESPUESTA: " + cr + Environment.NewLine + "DESCRIPCIÓN: " + descripcion, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("NO EXISTE LA RECARGA SELECCIONADA", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lector.Close();

                    //IMPRIMIR TICKET *****************************************************************************************************************
                    
                        cmd.CommandText = "Select * from Recarga where no_transaccion ='" + transaccion_rec + "'";
                        lector = cmd.ExecuteReader();
                        try
                        {
                            //NUEVOS DATOS PARA EL TICKET**************************************************************************************************

                            if (lector.HasRows)
                            {
                                lector.Read();

                                transaccion_0 = lector.GetInt32(0);
                                telefono_1 = lector.GetString(1);
                                sku_2 = lector.GetString(2);
                                fecha_hora_3 = lector.GetString(3);
                                cve_estado_4 = lector.GetString(4);
                                cadena_5 = lector.GetInt32(5);
                                establecimiento_6 = lector.GetInt32(6);
                                terminal_7 = lector.GetInt32(7);
                                cajero_8 = lector.GetString(8);
                                clave_9 = lector.GetString(9);
                            cr = lector.GetString(10);
                            producto = lector.GetString(12);

                                decimal montoo;
                                montoo = lector.GetDecimal(14);

                                monto = montoo.ToString("0.00");
                            

                                //MessageBox.Show("Monto string: " + monto);

                                producto_aux = producto;


                                if (producto_aux.Length > 13)
                                {
                                    producto_aux = producto_aux.Substring(0, 13);
                                }
                                CrearTicket ticket = new CrearTicket();
                                //verificar almacen
                                string sucursal = args[1].Substring(4, 2);

                                if (sucursal == "01" || sucursal == "02" || sucursal == "03" || sucursal == "04" || sucursal == "05" || sucursal == "13" || sucursal == "14" || sucursal == "15" || sucursal == "19" || sucursal == "20")
                                {
                                    almacen = "01";//GUADALAJARA
                                }
                                else if (sucursal == "06" || sucursal == "07" || sucursal == "08" || sucursal == "09")
                                {
                                    almacen = "02";//ATEQUIZA
                                }
                                else if (sucursal == "10" || sucursal == "11" || sucursal == "12")
                                {
                                    almacen = "03"; //IXTLAHUACAN
                                }
                                else if (sucursal == "21" || sucursal == "22" || sucursal == "23" || sucursal == "24" || sucursal == "25" || sucursal == "26" || sucursal == "27" || sucursal == "28" || sucursal == "29")
                                {
                                    almacen = "04"; //TLAJOMULCO
                                }

                                //ticket.TextoIzquierda(" ");
                                ticket.TextoCentro("********* RECARGA TAE *********");
                                ticket.TextoIzquierda(" ");
                                ticket.TextoCentro("CASA GUERRERO DEPARTAMENTAL");
                                ticket.TextoCentro("COMERCIAL DE RETIRO S.A. DE C.V.");
                                ticket.TextoCentro("" + Direccion);
                                ticket.TextoCentro("" + Ciudad);
                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda("Almacen:      " + almacen);
                                ticket.TextoIzquierda("Folio:        " + args[1]);
                                ticket.TextoIzquierda("Fecha:        " + fecha_hora_3.Substring(0, 10));
                                ticket.TextoIzquierda("Hora:         " + fecha_hora_3.Substring(11, 8));
                                ticket.TextoIzquierda("Vendedor:     CAJA " + args[1].Substring(4, 2));
                                ticket.TextoIzquierda(" ");
                                //ticket.TextoExtremos("FECHA : " + fecha_hora_3.Substring(0, 10), "HORA : " + fecha_hora_3.Substring(10, 9));
                                ticket.TextoIzquierda(" ");
                                ticket.EncabezadoVenta();
                                ticket.lineasGuio();
                                if (cr != "0")
                                {

                                    ticket.AgregaArticulo(producto_aux + " " + telefono_1, 0, montoo);
                                }
                                else
                                {
                                    ticket.AgregaArticulo(producto_aux + " " + telefono_1, 1, montoo);
                                }

                                ticket.lineasIgual();
                                if (cr != "0")
                                {

                                    ticket.TextoIzquierda("              TOTAL : $           0.00");
                                }
                                else
                                {
                                    ticket.AgregarTotales("              TOTAL : $", montoo);
                                }

                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda("Transaccion               " + transaccion_0.ToString());
                                ticket.TextoIzquierda("Autorizacion              " + num_autorizacion);
                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda(" ");
                                ticket.lineasIgual();
                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda(" ");

                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda(" ");
                                ticket.TextoIzquierda(" ");
                                ticket.CortaTicket();
                            // Revisar impresoras instaladas
                            int i;
                            string pkInstalledPrinters;
                            string impresora = "";
                            for (i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                            {
                                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                                if (printDoc.PrinterSettings.IsDefaultPrinter)
                                {
                                    impresora = printDoc.PrinterSettings.PrinterName;
                                }
                            }



                            ticket.ImprimirTicket("" + impresora);

                            if (cr == "0")
                                {
                                    montoSinPuntos = monto;
                                    montoSinPuntos = montoSinPuntos.Replace(".", "");
                                    int cantMonto = montoSinPuntos.Length;
                                    if (cantMonto == 4)
                                    {
                                        montoSinPuntos = "000" + montoSinPuntos;
                                    }
                                    else if (cantMonto == 5)
                                    {
                                        montoSinPuntos = "00" + montoSinPuntos;
                                    }

                                    cr = num_autorizacion.PadLeft(20, ' ');

                                    //MessageBox.Show(montoSinPuntos);
                                    //MessageBox.Show(cr.Length.ToString());
                                    string texto = "TRXMTC" + "0" + ID_Cadena + "0" + ID_Establecimiento + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                                    File.AppendAllLines(ruta, new String[] { texto });
                                    monto = "0.00";
                                }
                                else
                                {
                                    //YA NO GUARDA LAS RECARGAS FALLIDAS 
                                    /*
                                    montoSinPuntos = monto;
                                    montoSinPuntos = montoSinPuntos.Replace(".", "");
                                    int cantMonto = montoSinPuntos.Length;
                                    if (cantMonto == 4)
                                    {
                                        montoSinPuntos = "000" + montoSinPuntos;
                                    }
                                    else if (cantMonto == 5)
                                    {
                                        montoSinPuntos = "00" + montoSinPuntos;
                                    }

                                    //Cambio de cr

                                    cr = num_autorizacion.PadLeft(20, ' ');

                                    //MessageBox.Show(montoSinPuntos);
                                    //MessageBox.Show(cr.Length.ToString());

                                    string texto = "TRXMTC" + "0" + ID_Cadena + "0" + ID_Establecimiento + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                                    File.AppendAllLines(ruta, new String[] { texto });

                                */
                                }


                           
                            }
                            lector.Close();
                            cn.Close();
                        }
                        catch (Exception eeee)
                        {
                            MessageBox.Show(eeee.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    //TERMINA TICKET********************************************************************************************************************

                    //ACTUALIZAR EL ARCHIVO FTP********************************************************************************************************************
                    
                    try
                    {
                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp:" + Ruta_ftp + ID_Archivo + ID_Cadena + ID_Establecimiento + yyyymmdd + ".txt");

                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.Credentials = new NetworkCredential(User_ftp, Pass_ftp);
                        request.UsePassive = true;
                        request.UseBinary = true;
                        request.KeepAlive = true;
                        FileStream stream = File.OpenRead(ruta);
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        stream.Close();
                        Stream reqStream = request.GetRequestStream();
                        reqStream.Write(buffer, 0, buffer.Length);
                        reqStream.Flush();
                        reqStream.Close();
                    }
                    catch
                    {
                        MessageBox.Show("NO SE ACTUALIZO EL HISTORIAL, FAVOR DE CONTACTAR A SISTEMAS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception eeee)
                {
                    MessageBox.Show(eeee.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                this.recargaTableAdapter.FillByConsultas(this.recargasDataSet.Recarga);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        
    }
}
