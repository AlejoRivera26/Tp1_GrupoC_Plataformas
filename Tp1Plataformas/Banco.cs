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

        //ABM Usuario
        public bool altaUsuario(int dni, string nombre, string apellido, string mail, string contra, bool bloqueado)
        {
            try
            {
                Usuario nuevo = new Usuario(nombre, apellido, dni, mail, contra, bloqueado);
                userList.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaUsuario(int id)
        {
            Usuario aEliminar = userList[id];
            try
            {
                userList[id] = null;
                return true;
            }
            catch (Exception)
            {
                userList[id] = aEliminar;
                return false;
            }
        }

        public bool modificarUsuario(int id, int dni, string nombre, string mail, string apellido, string contra, bool bloqueado)
        {
            Usuario aModificar = userList[id];
            try
            {
                Usuario nuevo = new Usuario(nombre, apellido, dni, mail, contra, bloqueado);
                userList[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                userList[id] = aModificar;
                return false;
            }
        }

        //ABM Caja de Ahorro

        public bool altaCaja(int cbu, float saldo)
        {
            try
            {
                Caja_de_Ahorro nuevo = new Caja_de_Ahorro(cbu, saldo);
                cajasList.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaCaja(int id)
        {
            Caja_de_Ahorro aEliminar = cajasList[id];
            try
            {
                userList[id] = null;
                return true;
            }
            catch (Exception)
            {
                cajasList[id] = aEliminar;
                return false;
            }
        }

        public bool modificarCaja(int id, int cbu, float saldo)
        {
            Caja_de_Ahorro aModificar = cajasList[id];
            try
            {
                Caja_de_Ahorro nuevo = new Caja_de_Ahorro(cbu, saldo);
                cajasList[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                cajasList[id] = aModificar;
                return false;
            }
        }

        //ABM Plazo Fijo

        public bool altaPlazo(Usuario titular, float monto, DateTime fechaIni, DateTime fechaFin, float tasa, bool pagado)
        {
            try
            {
                Plazo_Fijo nuevo = new Plazo_Fijo(titular, monto, fechaIni, fechaFin, tasa, pagado);
                plazosFijos.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaPlazo(int id)
        {
            Plazo_Fijo aEliminar = plazosFijos[id];
            try
            {
                plazosFijos[id] = null;
                return true;
            }
            catch (Exception)
            {
                plazosFijos[id] = aEliminar;
                return false;
            }
        }

        public bool modificarPlazo(int id, Usuario titular, float monto, DateTime fechaIni, DateTime fechaFin, float tasa, bool pagado)
        {
            Plazo_Fijo aModificar = plazosFijos[id];
            try
            {
                Plazo_Fijo nuevo = new Plazo_Fijo(titular, monto, fechaIni, fechaFin, tasa, pagado);
                plazosFijos[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                plazosFijos[id] = aModificar;
                return false;
            }
        }

        //ABM Pagos

        public bool altaPago(Usuario usuario, float monto, bool pagado)
        {
            try
            {
                Pago nuevo = new Pago(usuario, monto, pagado);
                pagos.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaPago(int id)
        {
            Pago aEliminar = pagos[id];
            try
            {
                pagos[id] = null;
                return true;
            }
            catch (Exception)
            {
                pagos[id] = aEliminar;
                return false;
            }
        }

        public bool modificarPago(int id, Usuario usuario, float monto, bool pagado)
        {
            Pago aModificar = pagos[id];
            try
            {
                Pago nuevo = new Pago(usuario, monto, pagado);
                pagos[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                pagos[id] = aModificar;
                return false;
            }
        }

        //ABM Movimientos

        public bool altaMovimiento(Caja_de_Ahorro caja, string detalle, float monto, DateTime fecha)
        {
            try
            {
                Movimiento nuevo = new Movimiento(caja, detalle, monto, fecha);
                movimientos.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaMovimiento(int id)
        {
            Movimiento aEliminar = movimientos[id];
            try
            {
                movimientos[id] = null;
                return true;
            }
            catch (Exception)
            {
                movimientos[id] = aEliminar;
                return false;
            }
        }

        public bool modificarMovimiento(int id, Caja_de_Ahorro caja, string detalle, float monto, DateTime fecha)
        {
            Movimiento aModificar = movimientos[id];
            try
            {
                Movimiento nuevo = new Movimiento(caja, detalle, monto, fecha);
                movimientos[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                movimientos[id] = aModificar;
                return false;
            }
        }

        //ABM Tarjetas

        public bool altaTarjeta(Usuario titular, int numero, int codigoSeguridad, float limite, float consumos)
        {
            try
            {
                Tarjeta_de_Credito nuevo = new Tarjeta_de_Credito(titular, numero, codigoSeguridad, limite, consumos);
                tarjetas.Add(nuevo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajaTarjeta(int id)
        {
            Tarjeta_de_Credito aEliminar = tarjetas[id];
            try
            {
                tarjetas[id] = null;
                return true;
            }
            catch (Exception)
            {
                tarjetas[id] = aEliminar;
                return false;
            }
        }

        public bool modificarTarjeta(int id, Usuario titular, int numero, int codigoSeguridad, float limite, float consumos)
        {
            Tarjeta_de_Credito aModificar = tarjetas[id];
            try
            {
                Tarjeta_de_Credito nuevo = new Tarjeta_de_Credito(titular, numero, codigoSeguridad, limite, consumos);
                tarjetas[id] = nuevo;
                return true;
            }
            catch (Exception)
            {
                tarjetas[id] = aModificar;
                return false;
            }
        }


        //Metodos

        public bool iniciarSesion(string usuario, string pass)
        {
            bool encontrar = false;
            foreach (Usuario user in userList)
            {
                if (user.Nombre.Equals(usuario) && user.Contra.Equals(pass))
                    encontrar = true;
            }
            return encontrar;
        }

        //Getters

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

    }
}
