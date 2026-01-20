using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1clase
{
    
    public class Asignatura
    {
        private static int secc = 0;
        public string Id_Asignatura {  get; set; }
        public string Nombre { get; set; }
        public string Creditos { get; set; }
        public string Prerequisito { get; set; }

        public Asignatura( string nombre, string creditos,string pre) 
        {
            GenerarIdAsig();
            Nombre= nombre;
            Creditos= creditos;
            Prerequisito= pre;
        }

        private void GenerarIdAsig()
        {
            Id_Asignatura = $"{secc:D4}";
            secc++;
        }

    }
}
