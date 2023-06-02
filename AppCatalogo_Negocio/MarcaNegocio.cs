using App_Catalogo_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppCatalogo_Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos datos;

        public MarcaNegocio()
        {
            datos = new AccesoDatos();
        }

        /// <summary>
        /// Extrae las marcas almacenadas en la base de datos.
        /// </summary>
        /// <returns>Lista de marcas.</returns>
        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("Select Id, Descripcion from MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(aux);
                }

                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        /// <summary>
        /// Agrega la marca a la lista. La marca recibida por parámetro es validada para corroborar que esta no se encuentre ya en la lista.
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>Si la marca se encuentra en la lista, false. Caso contrario, true.</returns>
        public bool Agregar(Marca marca)
        {
            try
            {
                bool retorno = false;

                if (!ValidarMarca(marca))
                {
                    datos.SetConsulta($"Insert into MARCAS (Descripcion) values ('{marca.Descripcion}')");
                    datos.EjecutarAccion();
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        /// <summary>
        /// Modifica la marca recibida por parámetro. La marca recibida es validada contra la lista.
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>Si la marca se encuentra en la lista, false. Caso contrario, true.</returns>
        public bool Modificar(Marca marca)
        {
            try
            {
                bool retorno = false;

                if (!ValidarMarca(marca))
                {
                    datos.SetConsulta($"update MARCAS set Descripcion = '{marca.Descripcion}' where Id = {marca.Id}");
                    datos.EjecutarAccion();
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        /// <summary>
        /// Elimina la marca a la que pertenece el id pasado por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Si la marca pudo ser eliminada, true. Caso contrario, false.</returns>
        public bool Eliminar(int id)
        {
            try
            {
                bool retorno = false;

                if (!ValidarEliminacion(id))
                {
                    datos.SetConsulta("delete from MARCAS where Id = @id");
                    datos.SetParametros("@id", id);
                    datos.EjecutarAccion();
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        /// <summary>
        /// Valida la existencia de una marca pasada por parámetro, comparando su descripción contra la lista de marcas.
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>Si la marca existe, true. Caso contrario, false.</returns>
        private bool ValidarMarca(Marca marca)
        {
            bool existe = false;

            foreach (Marca fabricante in Listar())
            {
                if (fabricante.Descripcion.ToUpper().Equals(marca.Descripcion.ToUpper()))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        /// <summary>
        /// Valida, por medio del id pasado por parámetro, si la marca se encuentra asociada a algún artículo de la lista.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Si la marca se encuentra asociada a algun artículo, true. Caso contrario, false.</returns>
        private bool ValidarEliminacion(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool asociado = false;

            foreach (Articulo articulo in negocio.Listar())
            {
                if (articulo.Marca.Id == id)
                {
                    asociado = true;
                    break;
                }
            }

            return asociado;
        }
    }
}
