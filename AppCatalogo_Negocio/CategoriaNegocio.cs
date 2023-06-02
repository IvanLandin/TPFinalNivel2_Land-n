using App_Catalogo_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogo_Negocio
{
    public class CategoriaNegocio
    {
        AccesoDatos datos;

        public CategoriaNegocio()
        {
            datos = new AccesoDatos();
        }

        /// <summary>
        /// Extrae las categorías almacenadas en la base de datos.
        /// </summary>
        /// <returns>Lista de categorías.</returns>
        public List<Categoria> Listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("Select Id, Descripcion from CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategoria.Add(aux);
                }

                return listaCategoria;
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
        /// Agrega la categoría a la lista. La categoría recibida por parámetro es validada para corroborar que esta no se encuentre ya en la lista.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Si la categoría se encuentra en la lista, false. Caso contrario, true.</returns>
        public bool Agregar(Categoria categoria)
        {
            bool retorno = false;

            try
            {
                if (!ValidarMarca(categoria))
                {
                    datos.SetConsulta($"Insert into CATEGORIAS (Descripcion) values ('{categoria.Descripcion}')");
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
        /// Modifica la categoría recibida por parámetro. La categoría recibida es validada contra la lista.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Si la categoría se encuentra en la lista, false. Caso contrario, true.</returns>
        public bool Modificar(Categoria categoria)
        {
            bool retorno = false;

            try
            {
                if (!ValidarMarca(categoria))
                {
                    datos.SetConsulta($"update CATEGORIAS set Descripcion = '{categoria.Descripcion}' where Id = {categoria.Id}");
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
        /// Elimina la categoría a la que pertenece el id pasado por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Si la categoría pudo ser eliminada, true. Caso contrario, false.</returns>
        public bool Eliminar(int id)
        {
            bool retorno = false;

            try
            {
                if (!ValidarEliminacion(id))
                {
                    datos.SetConsulta("delete from CATEGORIAS where Id = @id");
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
        /// Valida la existencia de una categoría pasada por parámetro, comparando su descripción contra la lista de categorías.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>Si la categoría existe, true. Caso contrario, false.</returns>
        private bool ValidarMarca(Categoria categoria)
        {
            bool existe = false;

            foreach (Categoria elemento in Listar())
            {
                if (elemento.Descripcion.ToUpper().Equals(categoria.Descripcion.ToUpper()))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        /// <summary>
        /// Valida, por medio del id pasado por parámetro, si la categoría se encuentra asociada a algún artículo de la lista.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Si la categoría se encuentra asociada a algun artículo, true. Caso contrario, false.</returns>
        private bool ValidarEliminacion(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool asociado = false;

            foreach (Articulo articulo in negocio.Listar())
            {
                if (articulo.Categoria.Id == id)
                {
                    asociado = true;
                    break;
                }
            }

            return asociado;
        }

    }
}
