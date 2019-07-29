using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace CasaGuerrero
{
    class CrearTicket
    {
        StringBuilder linea = new StringBuilder();
        int maxCar = 40, cortar;

        public string lineasGuio()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";
            }
            return linea.AppendLine(lineasGuion).ToString();
        }

        public string lineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";
            }
            return linea.AppendLine(lineasAsterisco).ToString();
        }

        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";
            }
            return linea.AppendLine(lineasIgual).ToString();
        }

        public void TextoIzquierda(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                linea.AppendLine(texto);
            }
        }

        public void TextoDerecha(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                string espacios = "";

                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }

        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                string espacios = "";
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";

                int centrar = (maxCar - texto.Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto);

            }
        }

        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            if (textoIzquierdo.Length > 22)
            {
                cortar = textoIzquierdo.Length - 22;
                textoIzq = textoIzquierdo.Remove(22, cortar);
            }
            else
            { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;

            if (textoDerecho.Length > 24)
            {
                cortar = textoDerecho.Length - 24;
                textoDer = textoDerecho.Remove(24, cortar);
            }
            else
            { textoDer = textoDerecho; }

            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + textoDerecho;
            linea.AppendLine(textoCompleto);//agregamos la linea al ticket, al objeto en si.
        }
        /// <summary>
        /// PENDIENTE VER COMO HAY QUE PONERLE A LOS ENCABEZADOS
        /// </summary>
        public void EncabezadoVenta()
        {
            linea.AppendLine("PRODUCTO      |NUMERO   |CANT    |PRECIO  ");
        }

        public void AgregarTotales(string texto, decimal total)
        {
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 29)
            {
                cortar = texto.Length - 29;
                resumen = texto.Remove(29, cortar);
            }
            else
            { resumen = texto; }

            textoCompleto = resumen;
            valor = total.ToString("#,#.00");

            int nroEspacios = maxCar - (resumen.Length + valor.Length);

            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        public void AgregaArticulo(string articulo, int cant, decimal precio)
        {
            if (cant.ToString().Length <= 7 && precio.ToString().Length <= 11)
            {
                string elemento = "", espacios = "";
                bool bandera = false;
                //int nroEspacios = 0;

                if (articulo.Length > 24)
                {
                    
                    elemento += "   " + cant.ToString();

                    
                    elemento += "      " + precio.ToString();//Agregamos el precio a la variable elemento

                    int caracterActual = 0;

                    for (int longitudTexto = articulo.Length; longitudTexto > 24; longitudTexto -= 24)
                    {
                        if (bandera == false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 24) + elemento);
                            bandera = true;
                        }
                        else
                            linea.AppendLine(articulo.Substring(caracterActual, 24));

                        caracterActual += 24;
                    }
                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));

                }
                else //Si no es mayor solo agregarlo, sin dar saltos de lineas
                {
                    for (int i = 0; i < (24 - articulo.Length); i++)
                    {
                        espacios += " "; //Agrega espacios para completar los 20 caracteres
                    }
                    elemento = articulo + espacios;

                    
                    elemento += "   " + cant.ToString();

                    //Colocar el precio a la derecha.
                    
                    elemento += "      " + precio.ToString();

                    linea.AppendLine(elemento);//Agregamos todo el elemento: nombre del articulo, cant, precio, importe.
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportdas por éste.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportdas por éste.");
            }
        }
        public void CortaTicket()
        {
            linea.AppendLine("\x1B" + "m"); //Caracteres de corte. Estos comando varian segun el tipo de impresora
            linea.AppendLine("\x1B" + "d" + "\x00"); //Avanza 9 renglones, Tambien varian
        }

        public void AbreCajon()
        {
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //Caracteres de apertura cajon 0
        }

        public void ImprimirTicket(string impresora)
        {
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString()); //Imprime texto.
        }
    }

    public class RawPrinterHelper
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";
            di.pDataType = "RAW";


            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {

                if (StartDocPrinter(hPrinter, 1, di))
                {

                    if (StartPagePrinter(hPrinter))
                    {
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }

            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
