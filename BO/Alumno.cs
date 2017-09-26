﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Alumno
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string email;
        private int dni;
        private string ciudad;
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        #endregion

        #region Constructores
        public Alumno()
        {
            
        }

        public Alumno(string nombre, string apellido, string ciudad, int dni, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.dni = dni;
            this.email = email;
        }
        #endregion

    }
}
