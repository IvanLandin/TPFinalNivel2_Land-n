using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using App_Catalogo_Dominio;

namespace AppCatalogo_Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos;

        public ArticuloNegocio()
        {
            datos = new AccesoDatos();
        }
        
        /// <summary>
        /// Extrae los artículos con toda su información de la base de datos.
        /// </summary>
        /// <returns>Lista de artículos.</returns>
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.SetConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoría, A.ImagenUrl, A.Precio, A.IdCategoria, A.IdMarca From ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoría"];

                    lista.Add(aux);
                }

                return lista;
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
        /// Extrae los artículos con toda su información de la base de datos, en base a los parámetros ingresados por el usuario.
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="criterio"></param>
        /// <param name="filtro"></param>
        /// <returns>Lista filtrada de artículos.</returns>
        public List<Articulo> Listar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                string consulta = FormularConsulta(campo, criterio, filtro);
                datos.SetConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = SqlMoney.Parse(datos.Lector["Precio"].ToString());

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoría"];

                    lista.Add(aux);
                }

                return lista;
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
        /// Agrega un artículo a la base de datos.
        /// </summary>
        /// <param name="articulo"></param>
        public void Agregar(Articulo articulo)
        {
            try
            {
                datos.SetConsulta($"Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values ('{articulo.CodigoArticulo}', '{articulo.Nombre}', '{articulo.Descripcion}', @idMarca, @idCategoria, @urlImagen, @precio)");
                datos.SetParametros("@idMarca", articulo.Marca.Id);
                datos.SetParametros("@idCategoria", articulo.Categoria.Id);
                datos.SetParametros("@urlImagen", articulo.Imagen);
                datos.SetParametros("@precio", articulo.Precio);
                datos.EjecutarAccion();
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
        /// Modifica el artículo pasado por parámetros en la base de datos.
        /// </summary>
        /// <param name="articulo"></param>
        public void Modificar(Articulo articulo)
        {
            try
            {
                datos.SetConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagen, Precio = @precio where Id = @id");
                datos.SetParametros("@codigo", articulo.CodigoArticulo);
                datos.SetParametros("@nombre", articulo.Nombre);
                datos.SetParametros("@descripcion", articulo.Descripcion);
                datos.SetParametros("@idMarca", articulo.Marca.Id);
                datos.SetParametros("@idCategoria", articulo.Categoria.Id);
                datos.SetParametros("@imagen", articulo.Imagen);
                datos.SetParametros("@precio", articulo.Precio);
                datos.SetParametros("@id", articulo.Id);

                datos.EjecutarAccion();
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
        /// Elimina el artículo, al cual corresponde el id pasado por parámetros, de la base de datos.
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            try
            {
                datos.SetConsulta("delete from ARTICULOS where Id = @id");
                datos.SetParametros("@id", id);
                datos.EjecutarAccion();
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
        /// Formula la consulta para listar los artículos en base a filtros dispuestos por el usuario.
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="criterio"></param>
        /// <param name="filtro"></param>
        /// <returns>Un string que contiene el literal de la consulta.</returns>
        private string FormularConsulta(string campo, string criterio, string filtro)
        {
            string consulta = "Select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoría, Precio, ImagenUrl, A.Id, A.IdMarca, A.IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";

            switch (campo)
            {
                case "Código":
                    switch (criterio)
                    {
                        case "Comienza con...":
                            consulta += $"Codigo like '{filtro}%'";
                            break;
                        case "Termina con...":
                            consulta += $"Codigo like '%{filtro}'";
                            break;
                        case "Contiene...":
                            consulta += $"Codigo like '%{filtro}%'";
                            break;
                    }
                    break;
                case "Nombre":
                    switch (criterio)
                    {
                        case "Comienza con...":
                            consulta += $"Nombre like '{filtro}%'";
                            break;
                        case "Termina con...":
                            consulta += $"Nombre like '%{filtro}'";
                            break;
                        case "Contiene...":
                            consulta += $"Nombre like '%{filtro}%'";
                            break;
                    }
                    break;
                case "Descripción":
                    switch (criterio)
                    {
                        case "Comienza con...":
                            consulta += $"A.Descripcion like '{filtro}%'";
                            break;
                        case "Termina con...":
                            consulta += $"A.Descripcion like '%{filtro}'";
                            break;
                        case "Contiene...":
                            consulta += $"A.Descripcion like '%{filtro}%'";
                            break;
                    }
                    break;
                case "Marca":
                    switch (criterio)
                    {
                        case "Comienza con...":
                            consulta += $"M.Descripcion like '{filtro}%'";
                            break;
                        case "Termina con...":
                            consulta += $"M.Descripcion like '%{filtro}'";
                            break;
                        case "Contiene...":
                            consulta += $"M.Descripcion like '%{filtro}%'";
                            break;
                    }
                    break;
                case "Categoría":
                    switch (criterio)
                    {
                        case "Comienza con...":
                            consulta += $"C.Descripcion like '{filtro}%'";
                            break;
                        case "Termina con...":
                            consulta += $"C.Descripcion like '%{filtro}'";
                            break;
                        case "Contiene...":
                            consulta += $"C.Descripcion like '%{filtro}%'";
                            break;
                    }
                    break;
                case "Precio":
                    switch (criterio)
                    {
                        case "Mayor a...":
                            consulta += $"Precio > {filtro}";
                            break;
                        case "Menor a...":
                            consulta += $"Precio < {filtro}";
                            break;
                        case "Igual a...":
                            consulta += $"Precio = {filtro}";
                            break;
                    }
                    break;
            }

            return consulta;
        }
    }
}
