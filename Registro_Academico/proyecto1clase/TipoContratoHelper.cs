using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1clase
{
    internal class TipoContratoHelper
    {
        public static List<string> ObtenerContrato()
        {
            return Enum.GetNames(typeof(Tipocontract)).ToList();
        }
    }
}
