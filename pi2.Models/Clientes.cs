using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi2.Models
{
    public class Clientes
    {
        public int IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidosCliente { get; set; }
        public int  Dni { get; set; }
        public string Direccion { get; set; }

        public Nullable<int> TelefonoCliente { get; set; }

        
        public string Email { get; set; }
        public string Password { get; set; }

        public bool esAdmin { get; set; }
    }
}
