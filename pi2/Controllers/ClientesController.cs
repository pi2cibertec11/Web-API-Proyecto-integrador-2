using pi2.Modelos;
using pi2.Models;
using pi2.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace pi2.Controllers
{
    public class ClientesController : ApiController
    {
        private ClienteNegocios clientesNegocios;
        public ClientesController()
        {
            clientesNegocios = new ClienteNegocios();
        }
        [HttpGet]
        public List<Clientes> ListarClientes()
        {
            return clientesNegocios.ListarCliente();
        }
        [HttpPost]
        public Clientes Login(ClienteViewModel model)
        {
            Clientes cli = clientesNegocios.Login(model.Email,model.Password);
            return cli;
        }
        [HttpPost]
        public Boolean regclientes(Clientes cli)
        {
            return clientesNegocios.regclientes(cli);
        }
    }
}
