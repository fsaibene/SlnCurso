using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Profesor
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructores

        public Profesor()
        {

        }

        public Profesor(string nombre, string apellido, string email, string especialidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Especialidad = especialidad;
        }
        #endregion
    }
}
