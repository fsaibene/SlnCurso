using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Alumno : Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string email;
        private int dni;
        private string ciudad;
        #endregion
        #region Propiedades


        public int Legajo { get; set; }
        #endregion

        #region Constructores

        public Alumno(string nombre, string apellido, string ciudad, int dni, string email, int legajo) 
            : base(nombre, apellido, ciudad, dni, email)
        {
            Legajo = legajo;
        }
        #endregion
        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "\nLegajo: " + Legajo;
        }
        #endregion
    }
}
