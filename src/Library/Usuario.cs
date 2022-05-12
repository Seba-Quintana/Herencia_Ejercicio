using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public abstract class Usuario
    {
        // Nombre, Apellido, Cédula, Vehículo, Calificación como conductor y breve bio.
        protected string nombre;
        protected string apellido;
        protected string cedula;
        protected string calificacion;

        public string Nombre {get;}
        public string Apellido {get;}
        public string Cedula {get;}
        public string Calificacion {get;}
    }
}