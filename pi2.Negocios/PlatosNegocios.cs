using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pi2.Datos;
using pi2.Models;

namespace pi2.Negocios
{
    public class PlatosNegocios
    {
        private PlatosDatos platosDatos;

        public PlatosNegocios()
        {
            platosDatos = new PlatosDatos();
        }
        public List<Platos> ListarPlatos()
        {
            return platosDatos.ListarPlatos();
        }
        public Boolean regplatos(Platos pla)
        {
            return platosDatos.regplatos(pla);
        }
    }
}
