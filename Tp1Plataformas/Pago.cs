using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Pago
    {
        public Usuario usuario { get; set; }
        public float monto { get; set; }
        public Boolean pagado { get; set; }

        public Pago(Usuario usuario, float monto, bool pagado)
        {
            this.usuario = usuario;
            this.monto = monto;
            this.pagado = pagado;
        }
    }
}
