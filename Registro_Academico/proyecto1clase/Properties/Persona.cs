using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace proyecto1clase.Properties
{
   
    public class Persona
    {
        private DateTime fecha_nacmiento;

         public string Nombre { get; set; }
         public DateTime Fecha_nacimiento { get; set;}
         public int Edad { get; }
         public string Sexo { get; set; }
         


        public Persona(string nombre, DateTime fecha_nacimiento,string sexo)
        {
            Nombre = nombre;
            Fecha_nacimiento = fecha_nacimiento;
            Edad = CalcularEdad();
            Sexo = sexo;
        }

        private int CalcularEdad()
        {
            return DateTime.Now.Year-Fecha_nacimiento.Year;
        }

        public virtual string saludar()
        {
            return $"Hola, soy {Nombre} y tengo {Edad}";
        }

    }

}
