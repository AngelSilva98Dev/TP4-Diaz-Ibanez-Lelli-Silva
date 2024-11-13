using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Clase_Vuelos
    {
        public string CodigoDeVuelo { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string NombrePiloto { get; set; }
        public string NombreCopiloto { get; set; }
        public int CapacidadMax { get; set; }
        public int CantPasajeros { get; set; }


        public Clase_Vuelos()
        {
        }
        public Clase_Vuelos(string codigoDeVuelo, DateTime fechaSalida, DateTime fechaLlegada, string nombrePiloto, string nombreCopiloto, int capacidadMax) 
        {
            CodigoDeVuelo = codigoDeVuelo;
            FechaSalida = fechaSalida;
            FechaLlegada = fechaLlegada;
            NombrePiloto = nombrePiloto;
            NombreCopiloto = nombreCopiloto;
            CapacidadMax = capacidadMax;
            CantPasajeros = 0;
        }

        public bool RegistrarPasajeros(int pasajeros)
        {
            if(CantPasajeros + pasajeros <= CapacidadMax)
            {
                CantPasajeros += pasajeros;
                return true; 
            }
            return false;
        }

        public double CalcularPorcentajeOcupacion()
        {
            if (CapacidadMax == 0) return 0; 
            return (CantPasajeros / (double)CapacidadMax) * 100;
        }
        public override string ToString()
        {
            return $"Código: {CodigoDeVuelo}, Salida: {FechaSalida}, Llegada: {FechaLlegada}, Piloto: {NombrePiloto}, Copiloto: {NombreCopiloto}, Ocupación: {CalcularPorcentajeOcupacion():F2}%";
        }
    }
}
