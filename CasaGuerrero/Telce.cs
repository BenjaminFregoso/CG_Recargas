using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Drawing.Printing;
using System.Diagnostics;

namespace CasaGuerrero
{
    public partial class Recarga : Form
    {

        Metodos serv = new Metodos();

        private ComboBox comboInstalledPrinters = new ComboBox();
        private PrintDocument printDoc = new PrintDocument();
        int transaccion_0, transaccion_con, cadena_5, establecimiento_6, terminal_7;
        string descripcion;
        string cr;
        string telefono_1, sku_2, fecha_hora_3, fecha_hora_con, cve_estado_4, cajero_8, clave_9, num_autorizacion, codigo_compra;
        string ruta;
        string montoSinPuntos;
        string[] args = Environment.GetCommandLineArgs();
        string almacen;
        String yyyymmdd = "", dia, mes;
        //Metodo para traer los datos de la base de datos general 
        string ID_Archivo, ID_Cadena, ID_Establecimiento, ID_Terminal, ID_Cajero, ID_clave, Estado, Direccion, Ciudad, Ruta_Serv, Ruta_ftp, User_ftp, Pass_ftp;

        private void Telce_Load(object sender, EventArgs e)
        {
            
            //this.panel4.BackColor = Color.Transparent;
            this.panel3.BackColor = Color.Transparent;
            this.panel2.BackColor = Color.Transparent;
            this.panel1.BackColor = Color.Transparent;

            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.Planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.recargasDataSet.Planes);
            

            txtNum1.MaxLength = 10;//asignamos la maxima cantidad de caracteres que en este caso serian 10
            txtNum2.MaxLength = 10;//asignamos la maxima cantidad de caracteres que en este caso serian 10
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersWidth = 200;
            
            Bitmap imgvirgin = Properties.Resources.VIRGINMOBILE;
            Bitmap imgalo = Properties.Resources.ALO;
            Bitmap imgmovistar = Properties.Resources.MOVISTAR;
            Bitmap imgunefon = Properties.Resources.UNEFON;
            Bitmap imgatat = Properties.Resources.ATT;
            Bitmap imgnextel = Properties.Resources.NEXTEL;
            Bitmap imgtelcel = Properties.Resources.TELCEL;
            Bitmap imgintelcel = Properties.Resources.Internet_telcel;
            Bitmap imgsinlimite = Properties.Resources.SINLIMITE;
            

            switch (eleccion)
            {
                //load virgin
                case 1:
                    btnCambiante.BackgroundImage = imgvirgin;
                    planesBindingSource.Filter = "marca = 'Virgin'";
                    break;
                //load alo
                case 2:
                    btnCambiante.BackgroundImage = imgalo;
                    planesBindingSource.Filter = "marca = 'Alo'";
                    break;
                //load movistar
                case 3:
                    btnCambiante.BackgroundImage = imgmovistar;
                    planesBindingSource.Filter = "marca = 'Movistar'";
                    break;
                //Unefon
                case 4:
                    btnCambiante.BackgroundImage = imgunefon;
                    planesBindingSource.Filter = "marca = 'Unefon'";
                    break;
                // load atat 
                case 5:
                    btnCambiante.BackgroundImage = imgatat;
                    planesBindingSource.Filter = "marca = 'AtatIusacell'";
                    break;
                // load nextel
                case 6:
                    btnCambiante.BackgroundImage = imgnextel;
                    planesBindingSource.Filter = "marca = 'Nextel'";
                    break;
                //Load telcel
                case 7:
                    btnCambiante.BackgroundImage = imgtelcel;
                    planesBindingSource.Filter = "marca = 'Telcel'";

                    break;
                //Load internet
                case 8:
                    btnCambiante.BackgroundImage = imgintelcel;
                    planesBindingSource.Filter = "marca = 'Internet'";
                    break;
                //Load internet
                case 9:
                    btnCambiante.BackgroundImage = imgsinlimite;
                    planesBindingSource.Filter = "marca = 'TelcelAmigoSinLimite'";
                    break;
            }

            dataGridView1.Select();
            
            // TODO: esta línea de código carga datos en la tabla 'recargasDataSet.General' Puede moverla o quitarla según sea necesario.
            this.generalTableAdapter.Fill(this.recargasDataSet.General);
            
            //GENERAL*********************************************************************************************************************
            DatosGenneral();
            

            dia = DateTime.Today.Day.ToString();//obtenemos el dia
            mes = DateTime.Today.Month.ToString();//obtenemos el mes
            if (dia.Length == 1) { dia = "0" + dia; }//si la cantidad de caracteres del dia es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados
            if (mes.Length == 1) { mes = "0" + mes; }//si la cantidad de caracteres del mes es 1 le agregamos el 0 al inicio para cumplir con la cantidad de caracteres solicitados
            
            //*********CREAR LA CARPETA Y EL ARCHIVO .TXT***********
            yyyymmdd = DateTime.Today.Year.ToString() + mes + dia; //obtenemos el año mes y dia

            ruta = @"" + Ruta_Serv + ID_Archivo +"0" + ID_Cadena +"0"+ ID_Establecimiento + yyyymmdd + ".txt";//creamos la ruta                                                       //De tabla
            //ruta = @"" + Ruta_Serv + ID_Archivo + ID_Cadena + ID_Establecimiento + yyyymmdd + ".txt";//creamos la ruta

            if (File.Exists(ruta) == false)
            {
                using (var fileStream = File.Create(ruta))
                {
                    fileStream.Flush();
                }
            }

            string[] args = Environment.GetCommandLineArgs();//extraemos el numero de operacion
            if (args[1] == "12345678912")
            {
                this.Close();
            }

            // PRUEBAS MessageBox.Show("NUMERO DE OPERACION: " + args[1]);
        }
        
        private void planesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
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
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData != Keys.Escape)
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Escape) { Close(); }
            return true;
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                    //Aqui se obtiene la fila seleccionada.
                    String monto;
                    monto = row[0].Cells["costo"].Value.ToString();
                    txtMonto.Text = monto.Replace(",", ".");
                    txtNum1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length < 10)
            {
                txtNum2.Enabled = false;
                txtNum2.Text = "";
            }
            else
            {
                txtNum2.Enabled = true;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int eleccion;

        public Recarga(int elec)
        {
            InitializeComponent();
            
            this.eleccion = elec;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Enter(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                //Aqui se obtiene la fila seleccionada.
                String monto;
                monto = row[0].Cells["costo"].Value.ToString();
                txtMonto.Text = monto.Replace(",", ".");
                //txtNum1.Focus();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString()   );   
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnum2_textchanged(object sender, EventArgs e)
        {
            try
            {
                string num1 = txtNum1.Text.Substring(0, txtNum2.Text.Length);
                string num2 = txtNum2.Text.Substring(0, txtNum2.Text.Length);

                if (num1 != num2)
                {
                    txtNum2.BackColor = Color.Red; btnRecarga.Enabled = false;
                }
                else
                {
                    if(txtNum2.Text.Length == 10)
                    {
                        btnRecarga.Enabled = true;
                    }
                    else
                    {
                        btnRecarga.Enabled = false;
                    }

                    txtNum2.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(iO.Message);
            }
        }

        private void txtNum1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

            if (txtNum1.Text.Length <= 10)
            {
                txtNum1.PasswordChar = '\0';
                txtNum1.BackColor = Color.White;
            }

        }

        private void txtNum1_Leave_1(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0 && txtNum1.Text.Length < 10)
            {
                txtNum1.BackColor = Color.Red;
                
            }
            else
            {
                txtNum1.BackColor = Color.White;
                
            }
            if (txtNum1.Text.Length == 10 && txtNum1.BackColor == Color.White)
            {
                
                txtNum1.PasswordChar = '*';
            }
            else
            {
                txtNum1.PasswordChar = '\0';
                //txtNum1.BackColor = Color.Red;
                /*txtNum2.Focus();
                MessageBox.Show("Debes de ingresar los 10 caracteres primero");*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            consulta();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
        }

        private void btnConsulta_Enter(object sender, EventArgs e)
        {
            ConsultaRecargas form = new ConsultaRecargas();
        }
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                    //Aqui se obtiene la fila seleccionada.
                    String monto;
                    monto = row[0].Cells["costo"].Value.ToString();

                    txtMonto.Text = monto.Replace(",", ".");
                    txtNum1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                //MessageBox.Show("Datos: " + ID_Archivo + ID_Cadena + ID_Establecimiento + ID_Terminal + ID_Cajero + ID_clave + Estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       
        // CUANDO DEJEMOS EL FOCO DEL BOTON DE "CANCELAR" SE IRA AL FOCO DE CONSULTAR *******************************************
        private void BtnCancelar_Leave(object sender, EventArgs e)
        {
            //btnConsultar.Focus();
        }
        // CUANDO CAMBIA EL TEXTO ***********************************************************************************************
        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string num1 = txtNum1.Text.Substring(0, txtNum2.Text.Length);
                string num2 = txtNum2.Text.Substring(0, txtNum2.Text.Length);

                if (num1 != num2) { txtNum2.BackColor = Color.Red; }
                else { txtNum2.BackColor = Color.White; }
            }
            catch (Exception)
            {
                //MessageBox.Show(iO.Message);
            }
        }
        // EVENTO CUANDO SE HACE CLIC SOBRE UNA FILA DE LA TABLA ****************************************************************
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                //Aqui se obtiene la fila seleccionada.
                String monto;
                monto = row[0].Cells["costo"].Value.ToString();
                txtMonto.Text = monto.Replace(",", ".");
                //txtNum1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // CUANDO DEJAMOS EL FOCO DEL NUMERO 2 *****************************************************************************************
        private void TxtNum2_Leave(object sender, EventArgs e)
        {
            
            if (txtNum2.Text.Length == 0 || txtNum2.Text.Length == 10 && txtNum2.BackColor == Color.White)
            {
                
                    
            }
            else
            {
                txtNum2.PasswordChar = '\0';
                txtNum2.BackColor = Color.Red;
                /*txtNum2.Focus();
                MessageBox.Show("Debes de ingresar los 10 caracteres primero");*/
            }
        }

        // CUANDO PULSAMOS UNA TECLA SOBRO EL CAMPO TEXTO DEL NUMERO 1 *****************************************************************
        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

            if (txtNum1.Text.Length <= 10)
            {
                txtNum1.PasswordChar = '\0';
                txtNum1.BackColor = Color.White;
            }
        }
        // CUANDO DEJAMOS EL FOCO DE NUMERO 1 VERIFICAMOS QUE SE HAYA INGRERSADO LOS 10 DIGITOS DE LO CONTRARIO LO OBLIGAMOS ************
        private void TxtNum1_Leave(object sender, EventArgs e)
        {
        }
        // CUANDO PRESIONAMOS UNA TECLA SOBRE EL TEXTBOX 2 *******************************************************************************
        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //instruciones para validar que los caracteres ingresados sean numericos
                if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }

                if (txtNum2.Text.Length <= 10 && txtNum2.Text == txtNum1.Text)
                {
                    txtNum2.PasswordChar = '\0';
                    txtNum2.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,"CASA GUERRERO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void consulta()
        {

            Cursor.Current = Cursors.WaitCursor;
            
            String producto;

            //Hacer consulta

            try
            {
                //creamos los objetos para el WEB SERVICE
                WSMTCenter.ServiceSoapClient ws = new WSMTCenter.ServiceSoapClient();
                WSMTCenter.recargaRequestBody peticion = new WSMTCenter.recargaRequestBody();
                WSMTCenter.recargaResponseBody respuesta = new WSMTCenter.recargaResponseBody();

                WSMTCenter.InputConsulta inputConsulta = new WSMTCenter.InputConsulta();
                WSMTCenter.OutputConsulta outputConsulta = new WSMTCenter.OutputConsulta();
                WSMTCenter.Cuenta cuenta = new WSMTCenter.Cuenta();
                
                //Conexion a la base de datos 
                String servidor = serv.GetServidor();
                SqlConnection cn = new SqlConnection(servidor);
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                SqlDataReader lector;
                SqlDataReader lector2;
                //CAMBIO POR NUMERO DE OPERACION || HECHO 02/24/2019
                cmd.CommandText = "Select * from Recarga where operacion = '" + args[1] + "'";
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
                    //CAMBIAR POR NUMERO DE TRANSACCION RECARGA || HECHO 02/24/2019
                    cmd.CommandText = "Select * from Consulta where no_transaccion_rec ='" + transaccion_0 +"'";
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
                    //UPDATE EN NUMERO NO_TRANSACCION_REC || HECHO 02/24/2019
                    cmd.CommandText = "update Consulta set no_autorizacion = '" + num_autorizacion + "'  where no_transaccion_rec ='" + transaccion_0 + "'";
                    cmd.ExecuteNonQuery();
                    //NUMERO DE OPERACION|| HECHO 02/24/2019
                    cmd.CommandText = "update Recarga set code = '" + cr + "', no_autorizacion = '" + num_autorizacion + "', descripcion = '" + descripcion + "' where operacion = '" + args[1] + "'";
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
                    MessageBox.Show("NO EXISTE LA RECARGA SELECCIONADA, CONTACTAR A SISTEMAS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTON QUE VALIDA QUE LOS DATOS INGRESADOS SEAN LOS CORRECTOS Y EN CASO DE QUE SI ENVIAR LOS PARAMETROS SOLICITADOS DEL WEB SERVICE
        private void BtnRecarga_Click(object sender, EventArgs e)
        {
            String servidor = serv.GetServidor();
            SqlConnection cn = new SqlConnection(servidor);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            SqlDataReader lector;

            //VALIDAR QUE NO EXISTA OTRA RECARGA CON EL MISMO NÚMERO DE OPERACIÓN QUE TENGA CODIGO EXITOSO || HECHO 24/06/2019
            string codigo_validar="";
            try { 

                cmd.CommandText = "Select * from Recarga where operacion = '" + args[1] + "' and code = '0'";
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    codigo_validar = lector.GetString(10);
                }
                lector.Close();
            }
            catch (Exception ue){
            }

            if (codigo_validar == "0")
            {
                MessageBox.Show("LA RECARGA CON EL NÚMERO DE OPERACIÓN " + args[1] + " YA FUE REALIZADA, COBRA LA RECARGA Y REIMPRIME LOS TICKETS EN CASO DE SER NECESARIO", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            //TERMINA VALIDAR QUE NO EXISTA OTRA RECARGA IGUAL 

            cr = "";
            Cursor.Current = Cursors.WaitCursor;
            String sku1, producto, costo;
            //validar que la cantidad de caracteres sean 10
            if (txtNum1.TextLength < 10 || txtNum2.TextLength < 10) {  this.Refresh(); MessageBox.Show("FAVOR DE INGRESAR LOS 10 DÍGITOS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            //validar que los numeros ingresados sean iguales
            else if (txtNum1.Text != txtNum2.Text) {this.Refresh(); MessageBox.Show("LOS NÚMEROS NO COINCIDEN FAVOR DE VERIFICARLOS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            //SI TODO SALE BIEN SE ENVIARAN LOS PARAMETROS AL WEB SERVICE Y EL MONTO SE REINICIARA EN CEROS PARA QUE NO SE PUEDA ENVIAR 
            //LA PETICION DE LA RECARGA 2 VECES O MAS EN CASO DE QUE LA CAJERA LO PULSE POR ERROR MAS DE 1 VEZ
            else
            {
                try

                {
                    //creamos los objetos para el WEB SERVICE
                    WSMTCenter.ServiceSoapClient ws = new WSMTCenter.ServiceSoapClient();
                    WSMTCenter.recargaRequestBody peticion = new WSMTCenter.recargaRequestBody();
                    WSMTCenter.recargaResponseBody respuesta = new WSMTCenter.recargaResponseBody();
                    WSMTCenter.InputRecarga inputRecarga = new WSMTCenter.InputRecarga();
                    WSMTCenter.OutputRecarga outputRecarga = new WSMTCenter.OutputRecarga();
                    WSMTCenter.Cuenta cuenta = new WSMTCenter.Cuenta();

                    // obtenemos la fila seleccionada.
                    DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;

                    sku1 = row[0].Cells["sku"].Value.ToString();
                    producto = row[0].Cells["producto"].Value.ToString();
                    costo = row[0].Cells["costo"].Value.ToString();
                    codigo_compra = row[0].Cells["codigo"].Value.ToString();
                    //MessageBox.Show("Codigo compra: " +codigo_compra);
                    
                    //Error para ir a boton
                    //string fecha = serv.Getfecha(DateTime.Now.ToString());
                    string fecha = serv.Getfecha(DateTime.Now.ToString("MMddyyyy HHmmss"));
                    //MessageBox.Show(fecha);
                    //Estado, cuentacadena,  cuentaesta, cuentater, cuentacaj, cuenta clave, TABLA gener
                    
                    try
                    {


                        cmd.CommandText = string.Format("insert into Recarga ([telefono],[sku],[fecha_hora],[cve_estado],[cuentaCadena],[cuentaEstablecimiento],[cuentaTerminal],[cuentaCajero],[cuentaClave],[producto],[operacion],[costo],[codigo])  values('" + txtNum2.Text + "','" + sku1 + "','" + fecha + "', '" + Estado + "', '" + ID_Cadena + "', '" + ID_Establecimiento + "', '" + ID_Terminal + "', '" + ID_Cajero + "', '" + ID_clave + "', '" + producto + "',  '" + args[1] + "' , '" + costo + "','" + codigo_compra + "')");
                       
                        cmd.ExecuteNonQuery();
                        //POR NUMERO DE OPERACION || HECHO 02/04/2019 
                        //POR NUMERO DE OPERACION CON SELECCION DESCENDENTE || HECHO 30/04/2019
                        //POR NÚMERO DE OPERACION CON TOP 1 || 24/06/2019
                        cmd.CommandText = "Select top 1 * from Recarga where operacion = '" + args[1] + "' order by no_transaccion desc";
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

                            //PRUEBAS MessageBox.Show("Datos de SELECT: "+transaccion_0 +"--"+ telefono_1 + "--" + sku_2 + "--" + fecha_hora_3 + "--" + cve_estado_4 + "--" + cadena_5 + "--" + establecimiento_6 + "--" + terminal_7 + "--" + cajero_8 + "--" + clave_9);

                            cuenta.cadena = cadena_5;
                            cuenta.establecimiento = establecimiento_6;
                            cuenta.terminal = terminal_7;
                            cuenta.cajero = cajero_8;
                            cuenta.clave = clave_9;
                            inputRecarga.cuenta = cuenta;

                            inputRecarga.no_transaccion = transaccion_0;
                            inputRecarga.telefono = telefono_1;
                            inputRecarga.sku = sku_2;
                            inputRecarga.fecha_hora = fecha_hora_3;
                            inputRecarga.cve_estado = cve_estado_4;

                            lector.Close();
                            try
                            {
                                
                                outputRecarga = ws.recarga(inputRecarga);
                                cr = outputRecarga.codigo_respuesta.ToString();
                                descripcion = outputRecarga.descripcion_respuesta.ToString();
                                num_autorizacion = outputRecarga.no_autorizacion.ToString();
                            }
                            catch
                            {
                                cr = "-600";
                            }
                            Cursor.Current = Cursors.Default;

                            //POR NUMERO DE OPERACION || HECHO 02/04/2019
                            //POR N
                            cmd.CommandText = "update Recarga set code = '" + cr + "', no_autorizacion = '" + num_autorizacion + "', descripcion = '" + descripcion + "' where operacion = '" + args[1] + "' and no_transaccion = '"+transaccion_0+"' ";
                            cmd.ExecuteNonQuery();


                            //Ir a ventana de consulta
                            if (cr == "-3" || cr == "71" || cr == "-600" || cr == "")
                            {
                                //MessageBox.Show("CÓDIGO DE RESPUESTA: "+code+ Environment.NewLine+ "CONSULTANDO LA RECARGA, PRESIONE EL BOTON PARA CONTINUAR", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                fecha = serv.Getfecha(DateTime.Now.ToString("MMddyyyy HHmmss"));
                                // TRANSACCION REC AQUI -- NOTA
                                cmd.CommandText = "insert into Consulta values('" + transaccion_0 + "', '" + fecha + "', '')";
                                cmd.ExecuteNonQuery();
                                consulta();
                            }
                            else
                            {
                                if (cr == "0")
                                {
                                    MessageBox.Show("RECARGA EXITOSA, CÓDIGO: " + cr, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                else
                                {
                                    MessageBox.Show("LA RECARGA NO SE REALIZÓ" + Environment.NewLine + "CÓDIGO DE RESPUESTA: " + cr + " DESCRIPCIÓN: " + descripcion, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }

                            }

                        }
                        else
                        {
                            Cursor.Current = Cursors.Default;

                            MessageBox.Show("NO EXISTE LA RECARGA SELECCIONADA, FAVOR DE CONTACTAR AL DEPARTAMENTO DE SISTEMAS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        lector.Close();
                        cn.Close();

                        txtNum1.Text = "";
                        txtNum2.Text = "";

                    }
                    catch (Exception eu)
                    {
                        if(eu.Message == "Error converting data type varchar to numeric.")
                        {
                            MessageBox.Show("ERROR DE IDIOMA, POR FAVOR CONTACTA AL DEPARTAMENTO DE SISTEMAS", "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(eu.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        
                    }
                   

                    //IMPRIMIR TICKET *****************************************************************************************************************
                    try
                    {

                        if (cr == "0")
                        {
                            if (producto.Length > 13)
                            {
                                producto = producto.Substring(0, 13);
                            }
                            //CrearTicket ticket = new CrearTicket();

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
                            ticket.TextoCentro(""+Direccion);
                            ticket.TextoCentro(""+Ciudad);
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
                            ticket.AgregaArticulo(producto + " " + telefono_1, 1, decimal.Parse(txtMonto.Text));
                            ticket.lineasIgual();
                            ticket.AgregarTotales("              TOTAL : $", decimal.Parse(txtMonto.Text));
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
                            ticket.TextoIzquierda("*** AVISO IMPORTANTE: SI REQUIERE");
                            ticket.TextoIzquierda("FACTURA, SOLICITARLA UNICAMENTE");
                            ticket.TextoIzquierda("EL DIA DE LA COMPRA ***");
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

                            montoSinPuntos = txtMonto.Text;
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
                            string texto = "TRXMTC" + "0"+ID_Cadena + "0"+ID_Establecimiento + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                            File.AppendAllLines(ruta, new String[] { texto });
                            txtMonto.Text = "0.00";
                        }
                        else
                        {

                            //YA NO GUARDA LAS RECARGAS FALLIDAS || CAMBIO SOLICITADO POR CARLOS GAXIOLA
                            /*
                            montoSinPuntos = txtMonto.Text;
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

                            string texto = "TRXMTC" + "0"+ID_Cadena + "0"+ID_Establecimiento + fecha_hora_3.Substring(0, 10) + fecha_hora_3.Substring(11, 8) + montoSinPuntos + telefono_1 + cr;
                            File.AppendAllLines(ruta, new String[] { texto });
                            */
                        }
                    }
                    catch (Exception eeee)
                    {
                        MessageBox.Show(eeee.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message, "CASA GUERRERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Environment.Exit(1);


            }
            
        }
    }
}
