using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Banco
    {
        private List<Usuario> userList { get; }
        private List<Caja_de_Ahorro> cajasList { get; }
        private List<Plazo_Fijo> plazosFijos { get; }
        private List<Pago> pagos { get; }
        private List<Movimiento> movimientos { get; }
        private List<Tarjeta_de_Credito> tarjetas { get; }

        public Banco(List<Usuario> userList, List<Caja_de_Ahorro> cajasList, List<Plazo_Fijo> plazosFijos, List<Pago> pagos, List<Movimiento> movimientos, List<Tarjeta_de_Credito> tarjetas)
        {
            this.userList = userList;
            this.cajasList = cajasList;
            this.plazosFijos = plazosFijos;
            this.pagos = pagos;
            this.movimientos = movimientos;
            this.tarjetas = tarjetas;
        }


        public List<Usuario> obtenerUsuarios()
        {
            return userList.ToList();
        }

        public List<Caja_de_Ahorro> obtenerCajas()
        {
            return cajasList.ToList();
        }

        public List<Plazo_Fijo> obtenerPlazoFijo()
        {
            return plazosFijos.ToList();
        }

        public List<Pago> obtenerPago()
        {
            return pagos.ToList();
        }

        public List<Movimiento> obtenerMovimiento()
        {
            return movimientos.ToList();
        }

        public List<Tarjeta_de_Credito> obtenerTarjeta()
        {
            return tarjetas.ToList();
        }

        public void AddUserToList(Usuario usuario)
        {   
            userList.Add(usuario);
        }

        public void AddCajaToList(Caja_de_Ahorro caja)
        {
            cajasList.Add(caja);
        }

        public void AddPlazoTolist(Plazo_Fijo plazo)
        {
            plazosFijos.Add(plazo);
        }

        public void AddPagoToList(Pago pago)
        {
            pagos.Add(pago);
        }

        public void AddMovimientoToList(Movimiento movimiento)
        {
            movimientos.Add(movimiento);
        }

        public void AddTarjetaToList(Tarjeta_de_Credito tarjeta)
        {
            tarjetas.Add(tarjeta);
        }
    }
}
