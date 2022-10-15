using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Usuario : Banco
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }
        public string Contra { get; set; }
        public int intentosFallidos { get; set; }
        public Boolean bloqueado { get; set; }
        private List<Caja_de_Ahorro> cajasList { get; }
        private List<Plazo_Fijo> plazoFijo { get; }
        private List<Pago> pagos { get; }
        private List<Tarjeta_de_Credito> tarjetas { get; }

        public Usuario(string nombre, string apellido, int dNI, string mail, string contra, int intentosFallidos, bool bloqueado, List<Caja_de_Ahorro> cajasList, List<Plazo_Fijo> plazoFijo, List<Pago> pagos, List<Tarjeta_de_Credito> tarjetas)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Mail = mail;
            Contra = contra;
            this.intentosFallidos = intentosFallidos;
            this.bloqueado = bloqueado;
            this.cajasList = cajasList;
            this.plazoFijo = plazoFijo;
            this.pagos = pagos;
            this.tarjetas = tarjetas;
        }

        public Usuario(string nombre, string apellido, int dNI, string mail, string contra, bool bloqueado) : this(nombre, apellido)
        {
            DNI = dNI;
            Mail = mail;
            Contra = contra;
            this.bloqueado = bloqueado;
        }

        public Usuario(string nombre, string contra)
        {
            Nombre = nombre;
            Contra = contra;
        }


    }

}
