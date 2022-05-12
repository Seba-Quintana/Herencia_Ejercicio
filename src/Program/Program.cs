using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario pasajero1 = new Pasajero("", "", "", "");
            Usuario pasajero2 = new Pasajero("", "", "", "");
            Usuario pasajero3 = new Pasajero("", "", "", "");
            Usuario conductor1 = new Conductor("", "", "", "", "", "");
            Usuario conductorPool1 = new ConductorPool("", "", "", "", "", "", 3);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.Add(conductor1);
            rideShare.Add(conductorPool1);
            rideShare.Add(pasajero1);
            rideShare.Add(pasajero2);
            rideShare.Add(pasajero3);
        }
    }
}
