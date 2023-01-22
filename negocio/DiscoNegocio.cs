using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.Formato = new Edicion();
                    aux.Formato.Descripcion = (string)datos.Lector["Formato"];

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
                datos.cerrarConexion();
            }
        }

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into DISCOS (Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion) values(@Titulo,@FechaLanzamiento,@CantidadCanciones,@UrlImagenTapa,@IdEstilo,@IdTipoEdicion)");
                datos.setearParametro("@Titulo",nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento",nuevo.Fecha);
                datos.setearParametro("@CantidadCanciones",nuevo.CantidadCanciones);
                datos.setearParametro("@UrlImagenTapa",nuevo.UrlImagen);
                datos.setearParametro("@IdEstilo",nuevo.Genero.Id);
                datos.setearParametro("@IdTipoEdicion",nuevo.Formato.Id);
                datos.ejecutarAccion();
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
