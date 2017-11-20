using pi2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;


namespace pi2.Datos
{
    public class ClientesDatos
    {

        // CONEXION A BD +2
        string cadenaConexion = @"server=USER\SQL;database=proyecto;user id=sa;password=sql;";
        SqlConnection conexion;

        public ClientesDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public Clientes Login(string Email,string Password)
        {
            Clientes cli = null;
            conexion.Open();
            string query = " select * from Clientes2 ";
            query += " where Email=@Email ";
            query += " and Password=@Password ";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Email",Email);
            comando.Parameters.AddWithValue("@Password",Password);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                 cli = new Clientes();
                while (lector.Read())
                {
                    
                    cli.IDCliente = int.Parse(lector["IDCLiente"].ToString());
                    cli.NombreCliente = lector["NombreCliente"].ToString();
                    cli.ApellidosCliente = lector["ApellidosCliente"].ToString();
                    cli.Email = lector["Email"].ToString();
                    cli.TelefonoCliente = int.Parse(lector["TelefonoCliente"].ToString());

                    cli.Direccion = lector["Direccion"].ToString();
                    cli.Password = lector["Password"].ToString();
                    cli.esAdmin = bool.Parse(lector["esAdmin"].ToString());

                    
                }
            }
            conexion.Close();
            return cli;
        }

        public Boolean regclientes(Clientes cli)
        {
            Boolean dato = false;
           try{
                conexion.Open();
                string query = " insert into Clientes2 values (@name,@ape,@dni,@dir,@telf,@email,@pass,@esAdmin) ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@name", cli.NombreCliente);
                comando.Parameters.AddWithValue("@ape", cli.ApellidosCliente);
                comando.Parameters.AddWithValue("@dni", cli.Dni);
                comando.Parameters.AddWithValue("@dir", cli.Direccion);
                comando.Parameters.AddWithValue("@telf", cli.TelefonoCliente);
                comando.Parameters.AddWithValue("@email", cli.Email);
                comando.Parameters.AddWithValue("@pass", cli.Password);
                comando.Parameters.AddWithValue("@esAdmin", cli.esAdmin);
                SqlDataReader lector = comando.ExecuteReader();

                conexion.Close();
                dato = true;
            }
            catch
            {
                dato=false;
                
            }
            return dato;
        }


        public List<Clientes> ListarClientes()
        {
            List<Clientes> clientes = null;
            conexion.Open();
            string query = "select * from Clientes2";
            SqlCommand comand = new SqlCommand(query,conexion);
            SqlDataReader lector = comand.ExecuteReader();
            if (lector.HasRows)
            {
                clientes = new List<Clientes>();
                while (lector.Read())
                {
                    var cli = new Clientes();
                    cli.IDCliente = int.Parse(lector["IDCLiente"].ToString());
                    cli.NombreCliente = lector["NombreCliente"].ToString();
                    cli.ApellidosCliente =lector["ApellidosCliente"].ToString();
                    cli.Email = lector["Email"].ToString();
                    cli.TelefonoCliente = int.Parse(lector["TelefonoCliente"].ToString());

                    cli.Direccion =lector["Direccion"].ToString();
                    cli.Password = lector["Password"].ToString();
                    cli.esAdmin = bool.Parse(lector["esAdmin"].ToString());

                    clientes.Add(cli);
                }
            }


            conexion.Close();
            return clientes;
        }

        public Boolean actualizarClientes(Clientes cli) {

            Boolean dato = false;
            try
            {
                conexion.Open();

                string query = " update Clientes2 set NombreCliente=@name,ApellidosCliente=@ape,Dni=@dni,Direccion=@dir" +
                    "TelefonoCliente=@telf,Email=@email,Password=@pass";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@name", cli.NombreCliente);
                comando.Parameters.AddWithValue("@ape", cli.ApellidosCliente);
                comando.Parameters.AddWithValue("@dni", cli.Dni);
                comando.Parameters.AddWithValue("@dir", cli.Direccion);
                comando.Parameters.AddWithValue("@telf", cli.TelefonoCliente);
                comando.Parameters.AddWithValue("@email", cli.Email);
                comando.Parameters.AddWithValue("@pass", cli.Password);
                SqlDataReader lector = comando.ExecuteReader();



                conexion.Close();
                dato = true;
            }
            catch
            {
                dato = false;

            }
            return dato;
        }
        
        public Boolean eliminarClientes(Clientes cli)
        {
            Boolean dato = false;
            try
            {
                conexion.Open();

                string query = " delete from Clientes2  where IDCliente =@idcli";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idcli", cli.IDCliente);
                SqlDataReader lector = comando.ExecuteReader();

                conexion.Close();
                dato = true;
            }
            catch
            {
                dato = false;

            }
            return dato;
        }
    }
}
