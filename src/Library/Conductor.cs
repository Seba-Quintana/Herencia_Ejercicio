using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class Conductor : Usuario
    {
        protected string vehiculo;
        protected string bio;
        public Conductor(string nombre, string apellido, string cedula, string vehiculo, string calificacion, string bio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.vehiculo = vehiculo;
            this.calificacion = calificacion;
            this.bio = bio;
        }
        public string Vehiculo {get;}
        public string Bio {get;}
    }
}