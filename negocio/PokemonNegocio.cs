using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio; 


namespace negocio

{
     public class PokemonNegocio
    {

     
        public List <pokemon> Listar ()
        {
            List<pokemon> lista = new List<pokemon> ();
            SqlConnection conexion = new SqlConnection(); 
            SqlCommand comando = new SqlCommand ();
            SqlDataReader lector;  
            try
            {
                conexion.ConnectionString = "server = PANCH\\SQLEXPRESS; database= POKEDEX_DB ; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;  
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())

                {

                    pokemon aux = new pokemon ();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string) lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new dominio.Elemento(); 
                    aux.Tipo.Descripcion = (string)lector["tipo"];
                    aux.Debilidad = new dominio.Elemento ();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);

                }

                conexion.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public void agregar(pokemon nuevo)
        {

        }

        public void modificar(pokemon modificar) { }

    }
}

