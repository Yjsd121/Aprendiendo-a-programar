using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using proyecto1clase.Properties;

namespace proyecto1clase
{  
    public enum ModalidadCurso
    {
        Diraio,
        Sabatino
    }
    public class Curso
    {
        public string Id_Curso {  get; set; }
        public string CicloAcademico { get; set; }
        public ModalidadCurso Modalidad { get; set; }
        public Profesor Profesor { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<Alumno> Alumnos { get; set; }=new List<Alumno>();  
        public Dictionary<Alumno,double> Notas { get; set; }= new Dictionary<Alumno,double>();

        public Curso(string id_Curso, string cicloAcademico, ModalidadCurso modalidad, Profesor profesor, Asignatura asignatura)
        {
            Id_Curso = id_Curso;
            CicloAcademico = cicloAcademico;
            Modalidad = modalidad;
            Profesor = profesor;
            Asignatura = asignatura;
          
        }
        public bool AgregarAlumno(Alumno alumno)
        {
            if (!Alumnos.Contains(alumno)) //contains nos dice si la onda esta en la lista que le pasamos "Lista.contais(Alumno a buscar)
            {
                Alumnos.Add(alumno);
                return true;
            }
             return false;
        }
        public bool EmininarAlumno(Alumno alumno)
        {
            if (Alumnos.Contains(alumno))
            {
                Alumnos.Remove(alumno);
                Notas.Remove(alumno);
                return true;
            }
            return false;
        }
        public bool RegistrarNota(Alumno alumno,double nota)
        {
            if (Alumnos.Contains(alumno))
            {
                Notas[alumno]=nota;
                return true;
            }
            return false;
        }

        public Dictionary<Alumno,double> Obtenernota()
        {
            return Notas;
        }
    }
}
