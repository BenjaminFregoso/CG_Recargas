using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CasaGuerrero
{
    public class Metodos
    {
        string servidor = ConfigurationManager.ConnectionStrings["CasaGuerrero.Properties.Settings.recargasConnectionLocal"].ConnectionString.ToString();

       //string servidor = "Data Source = BENJAMIN-PC\\SQL2008; Initial Catalog = recargas; user id = sa; password = Admin123";

       public String GetServidor()
       {
            return servidor;
       }

       public bool isCaracterValido(Char c)
       {
           if ((c >= '0' && c <= '9'))
           {
               return true;
           }
           return false;
       }

        public string Getfecha(string fecha) {

            string dia, mes, año, hora, min, seg;
            int cantDia, cantMes, cantHora, cantMin, cantSeg;

            dia = DateTime.Now.Day.ToString();
            cantDia = dia.Length;
            mes = DateTime.Now.Month.ToString();
            cantMes = mes.Length;
            año = DateTime.Now.Year.ToString();
            hora = DateTime.Now.Hour.ToString();
            cantHora = hora.Length;
            min = DateTime.Now.Minute.ToString();
            cantMin = min.Length;
            seg = DateTime.Now.Second.ToString();
            cantSeg = seg.Length;
            
            if (fecha.Length < 20){
                if (cantDia <= 1){  dia = "0" + dia; }
                if (cantMes <= 1) { mes = "0" + mes; }
                if (cantHora <= 1) { hora = "0" + hora; }
                if (cantMin <= 1) { min = "0" + min; }
                if (cantSeg <= 1) { seg = "0" + seg; }
            }

            fecha = dia + "/" + mes + "/" + año + " " + hora + ":" + min + ":" + seg;

            return fecha;
        }

    }
}
