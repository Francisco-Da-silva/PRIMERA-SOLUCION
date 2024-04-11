using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;





namespace negocio
{
     public class ElementoNegocio
    {

        public List<Elemento> listar()
        {
            List < Elemento> lista = new List < Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select id , Descripcion From ELEMENTOS ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                }

                return lista;  

            }
            catch (Exception ex)
            {
                throw ex; 
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
