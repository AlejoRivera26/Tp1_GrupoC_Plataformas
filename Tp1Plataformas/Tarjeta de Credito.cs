using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Tarjeta_de_Credito
    {
        public Usuario titular { get; set; }
        public int numero { get; set; }
        public int codigoSeguridad { get; set; }
        public float limite { get; set; }
        public float consumos { get; set; }

        public Tarjeta_de_Credito(Usuario titular, int numero, int codigoSeguridad, float limite, float consumos)
        {
            this.titular = titular;
            this.numero = numero;
            this.codigoSeguridad = codigoSeguridad;
            this.limite = limite;
            this.consumos = consumos;
        }
    }
}
