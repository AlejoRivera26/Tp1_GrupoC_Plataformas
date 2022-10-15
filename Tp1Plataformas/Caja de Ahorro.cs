using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Plataformas
{
    class Caja_de_Ahorro
    {
        public int CBU;    
        public List<Usuario> userList { get => userList.ToList(); }
        public float saldo;

        public Caja_de_Ahorro(int CBU, List<Usuario> userList, float saldo)
        {
            
        }
    }
}
