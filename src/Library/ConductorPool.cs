using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class ConductorPool : Conductor
    {
        private int numPasajeros;
        public ConductorPool(string nombre, string apellido, string cedula, string vehiculo, string calificacion, string bio, int numPasajeros) : base(nombre, apellido, cedula, vehiculo, calificacion, bio)
        {
            if (numPasajeros <= 3)
                this.numPasajeros = numPasajeros;
        }
        public int NumPasajeros{get;}
    }
}