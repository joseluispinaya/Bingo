using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NFigurasBingo
    {
        #region "PATRON SINGLETON"
        private static NFigurasBingo daoEmpleado = null;
        private NFigurasBingo() { }
        public static NFigurasBingo GetInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new NFigurasBingo();
            }
            return daoEmpleado;
        }
        #endregion

        public Respuesta<bool> RegistrarFigura(string FiguraXml)
        {
            return DFigurasBingo.GetInstance().RegistrarFigura(FiguraXml);
        }

        public Respuesta<List<EFiguraDTO>> ObtenerFigura(int idFigura)
        {
            return DFigurasBingo.GetInstance().ObtenerFigura(idFigura);
        }

    }
}
