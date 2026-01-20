using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto1clase.Properties;

namespace proyecto1clase
{
   
    public enum Carreras
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
    public enum Tipocontract
    {
        Planta,
        Horario
    }
    public class Profesor:Persona
    {
        private static int _secuencia = 0;
        public string ID_Profesor { get; set; }
        public string Titulo { get;set; }
        
        public Carreras Jefatura { get; set; }
        public Tipocontract Contrato { get; set; }

        public Profesor(string nombre,DateTime fecha_nacimiento,string sexo, string titulo,Carreras carreras,Tipocontract contrato):base (nombre,fecha_nacimiento,sexo)
        {
            
            this.Jefatura = carreras;
            Titulo= titulo;
            Contrato= contrato;
            GetId();
        }

        private void GetId()
        {
            string anoactual = DateTime.Now.Year.ToString().Substring(2);
            string codigoJefa=((int)Jefatura).ToString("D3");
            ID_Profesor = $"{anoactual}-A0{codigoJefa}-{_secuencia:D4}";
            _secuencia++;
        }

        public override string saludar()
        {
            return $"Hola, soy el profesor {Nombre} con ID {ID_Profesor}, Titulo {Titulo} y tengo {Edad} años";
        }

    }
}
