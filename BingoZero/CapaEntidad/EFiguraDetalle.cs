using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EFiguraDetalle
    {
        public int IdDetalle { get; set; }
        public int IdFigura { get; set; }
        public string Columna { get; set; }
        public int Fila { get; set; }
    }
}
