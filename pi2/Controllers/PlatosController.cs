using System;
using pi2.Models;
using pi2.Negocios;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace pi2.Controllers
{
    public class PlatosController : ApiController
    {
        private PlatosNegocios platosNegocios;

        public PlatosController()
        {
            platosNegocios = new PlatosNegocios();
        }

        [HttpGet]
        public List<Platos> ListarPlatos()
        {
            return platosNegocios.ListarPlatos();
        }
        [HttpPost]
        public Boolean regplatos(Platos pla)
        {
            return platosNegocios.regplatos(pla);
        }

    }
}
