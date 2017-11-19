using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pi2.Models;
using System.Data.SqlClient;

namespace pi2.Datos
{
   public class PlatosDatos
    {
        string cadenaConexion = @"server=USER\SQL;database=proyecto;user id=sa;password=sql;";
        SqlConnection conexion;

        public  PlatosDatos(){
            conexion = new SqlConnection(cadenaConexion);

                    }
        public List<Platos> ListarPlatos()
        {
            List<Platos> platos = null;
            conexion.Open();
            string query = "select * from platos";
            SqlCommand comand = new SqlCommand(query, conexion);
            SqlDataReader lector = comand.ExecuteReader();
            if (lector.HasRows)
            {
                platos = new List<Platos>();
                while (lector.Read())
                {
                    var pla = new Platos();
                    pla.platoId = int.Parse(lector["PlatoId"].ToString());
                    pla.platoNombre = lector["platoNombre"].ToString();
                    pla.platodescrip = lector["platodescrip"].ToString();
                    pla.platoprice = decimal.Parse(lector["platoprice"].ToString());
                    pla.imageUrl = lector["imageUrl"].ToString();

                 

                    platos.Add(pla);
                }
            }


            conexion.Close();
            return platos;
        }



        public Boolean regplatos(Platos pla)
        {
            try
            {

                conexion.Open();
                string query = " insert into platos values (@nom,@des,@price,@img) ";

                SqlCommand comando = new SqlCommand(query, conexion);
                ;
                comando.Parameters.AddWithValue("@nom", pla.platoNombre);
                comando.Parameters.AddWithValue("@des", pla.platodescrip);
                comando.Parameters.AddWithValue("@price", pla.platoprice);
                comando.Parameters.AddWithValue("@img", pla.imageUrl);

                SqlDataReader lector = comando.ExecuteReader();

                conexion.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Boolean actualizarPlatos()
        {

            return false;
        }


        public Boolean eliminarPlatos()
        {

            return false;
        }
    }

}
