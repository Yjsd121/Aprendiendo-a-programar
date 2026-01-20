using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1clase.Properties
{
    public class Alumno:Persona
    {
        public string Carnet {  get; set; }

        public Alumno (string nombre, DateTime fecha_nacmiento, string sexo,string carnet):base(nombre,fecha_nacmiento,sexo)
        {
            Carnet = nombre;
        }

        public override string saludar()
        {
            return $"Hola, soy el Alumno {Nombre} con carnet {Carnet} y tengo {Edad} años";
        }
    }
}
