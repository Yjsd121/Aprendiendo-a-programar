using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto1clase.Properties;

namespace proyecto1clase
{
    public enum Carrera
    {
        IMS = 201,
        IME = 202,
        ICE = 203,
        IGI = 204,
        IEEE = 205,
        IEL = 206,
        LAF = 207,
        LCM = 208
    }
    public class Alumno:Persona
    {
        
        public string Carnet {  get; set; }
        public Carrera Carrera { get; set; }

        private static int _secuencial = 0;


        public Alumno(string nombre, DateTime fechanacimietno,string sexo,Carrera carrera) : base(nombre, fechanacimietno,sexo)
        {
            this.Carrera = carrera;
            GenerarCarnet();
            
        }

        private void GenerarCarnet()
        {
            string anoactual=DateTime.Now.Year.ToString().Substring(2);
            Carnet = $"{anoactual}-A0{(int)Carrera:D3}-{_secuencial:D4}";
            _secuencial++;
        }

        public override string saludar()
        {
            return $"Hola soy el alumno {Nombre} con carnet {Carnet} y tengo {Edad} años";
        }
    }
}
