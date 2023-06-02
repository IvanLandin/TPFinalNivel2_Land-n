using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppCatalogo_Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return this.lector; } }
        
        /// <summary>
        /// Constructor. Configura la dirección del servidor.
        /// </summary>
        public AccesoDatos()
        {
            this.conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            this.comando = new SqlCommand();
        }

        /// <summary>
        /// Settea la consulta por medio del string recibido por parámetro.
        /// </summary>
        /// <param name="consulta"></param>
        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        /// <summary>
        /// Ejecuta la lectura, creando una instancia de SqlDataReader.
        /// </summary>
        public void EjecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Ejecuta la consulta previamente setteada.
        /// </summary>
        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Settea los parámetros de la consulta.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="valor"></param>
        public void SetParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        /// <summary>
        /// Cierra la conexion con la base de datos.
        /// </summary>
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
    }
}
