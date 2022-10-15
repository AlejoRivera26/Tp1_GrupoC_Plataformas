using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Movimiento : Banco
    {
        public int id { get; set; }
        public Caja_de_Ahorro caja;
        public string detalle { get; set; }
        public float monto { get; set; }
        public DateTime fecha { get; set; }

        public Movimiento(Caja_de_Ahorro caja, string detalle, float monto, DateTime fecha)
        {
            this.caja = caja;
            this.detalle = detalle;
            this.monto = monto;
            this.fecha = fecha;
        }
    }
}
