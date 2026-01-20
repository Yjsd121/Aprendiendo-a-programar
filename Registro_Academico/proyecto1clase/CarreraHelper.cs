using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1clase
{
    public static class CarreraHelper
    {
        public static List<string> ObtenerCarreras()
        {
            return Enum.GetNames(typeof(Carrera)).ToList();
        }
    }
}
