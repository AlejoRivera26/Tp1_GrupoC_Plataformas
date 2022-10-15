using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Plazo_Fijo
    {
        public Usuario titular { get; set; }
        public float monto { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime fechaFin { get; set; }
        public float tasa { get; set; }
        public Boolean pagado { get; set; }

        public Plazo_Fijo(Usuario titular, float monto, DateTime fechaIni, DateTime fechaFin, float tasa, bool pagado)
        {
            this.titular = titular;
            this.monto = monto;
            this.fechaIni = fechaIni;
            this.fechaFin = fechaFin;
            this.tasa = tasa;
            this.pagado = pagado;
        }
    }
}
