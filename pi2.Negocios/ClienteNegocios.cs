using pi2.Datos;
using pi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi2.Negocios
{
    public class ClienteNegocios
    {
        private ClientesDatos clienteDatos;

        public ClienteNegocios()
        {
            clienteDatos = new ClientesDatos();
        }
        public Clientes Login(string Email,string Password)
        {
            return clienteDatos.Login(Email,Password);
        }

        public List<Clientes> ListarCliente()
        {
            return clienteDatos.ListarClientes();
        }
        public Boolean regclientes(Clientes cli)
        {
            return clienteDatos.regclientes(cli);
        }
        public Boolean ActualizarClientes(Clientes cli)
        {
            Boolean act = clienteDatos.actualizarClientes(cli);
            if (act==true){
                return true;
            }
            return false;
        }
    }
}
