using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Profesor: Persona
    {
        #region Propiedades
        public string Especialidad { get; set; }
        #endregion

        #region Constructores
        public Profesor(string nombre, string apellido, string ciudad, int dni, string email, string especialidad): base(nombre,apellido, ciudad, dni, email)
        {
            this.Especialidad = especialidad;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() +  "\nEspecialidad: " + Especialidad;
        }
    }
}
