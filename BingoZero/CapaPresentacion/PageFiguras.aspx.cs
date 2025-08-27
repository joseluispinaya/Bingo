using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using CapaEntidad;
using CapaNegocio;
using System.Xml.Linq;

namespace CapaPresentacion
{
	public partial class PageFiguras : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        [WebMethod]
        public static Respuesta<bool> GuardarFigura(EFigurasBingo eFigurasBingo, List<EFiguraDetalle> RequestList)
        {
            try
            {
                if (RequestList == null || !RequestList.Any())
                {
                    return new Respuesta<bool> { Estado = false, Mensaje = "La lista está vacía" };
                }

                XElement figurabin = new XElement("Figura",
                    new XElement("NombreFigura", eFigurasBingo.NombreFigura),
                    new XElement("Descripcion", eFigurasBingo.Descripcion)
                );

                XElement detalleFigura = new XElement("Detallefigura");

                foreach (EFiguraDetalle item in RequestList)
                {
                    detalleFigura.Add(new XElement("Item",

                        new XElement("Columna", item.Columna),
                        new XElement("Fila", item.Fila)
                        )

                    );
                }

                figurabin.Add(detalleFigura);

                // Llamar a RegistrarFigura en la capa de negocio
                Respuesta<bool> respuesta = NFigurasBingo.GetInstance().RegistrarFigura(figurabin.ToString());
                return respuesta;
            }
            catch (Exception ex)
            {
                // Capturar cualquier error y retornar una respuesta de fallo
                return new Respuesta<bool>
                {
                    Estado = false,
                    Mensaje = "Ocurrió un error: " + ex.Message
                };
            }
        }

        [WebMethod]
        public static Respuesta<List<EFiguraDTO>> ObtenerFigura(int idFigura)
        {
            try
            {
                Respuesta<List<EFiguraDTO>> Lista = NFigurasBingo.GetInstance().ObtenerFigura(idFigura);
                return Lista;
            }
            catch (Exception ex)
            {
                return new Respuesta<List<EFiguraDTO>>()
                {
                    Estado = false,
                    Mensaje = "Error al obtener los datos: " + ex.Message,
                    Data = null
                };
            }
        }

        [WebMethod]
        public static object ObtenerFiguraPrue(int idFigura)
        {
            Respuesta<List<EFiguraDTO>> Lista = NFigurasBingo.GetInstance().ObtenerFigura(idFigura);

            // Transformamos a [["B",0], ["G",0], ...]
            var resultado = Lista.Data.Select(f => new object[] { f.Columna, f.Fila }).ToList();

            return resultado;
        }
    }
}