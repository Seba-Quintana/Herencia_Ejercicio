using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class Pasajero : Usuario
    {
        public Pasajero(string nombre, string apellido, string cedula, string calificacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.calificacion = calificacion;
        }
    }
}