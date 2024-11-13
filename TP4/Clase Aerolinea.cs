using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP4
{
    public class Clase_Aerolinea
    {
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public List <Clase_Vuelos> Vuelos { get; set; }

        public Clase_Aerolinea()
        {
            Vuelos = new List<Clase_Vuelos>();
        }
        public Clase_Aerolinea(string razonSocial, string telefono, string domicilio) 
        {
            RazonSocial = razonSocial;
            Telefono = telefono;
            Domicilio = domicilio;
            Vuelos = new List<Clase_Vuelos>();
        }

        public void AgregarVuelo(Clase_Vuelos vuelo)
        {
            Vuelos.Add(vuelo);
        }

        public double CalcularOcupacionMedia()
        {            
            if (Vuelos.Count == 0) return 0;
            
            double suma = 0;
            foreach (Clase_Vuelos vuelo in Vuelos)
            {
                suma += vuelo.CalcularPorcentajeOcupacion();
            }
            return suma / Vuelos.Count;
        }

        public string ObtenerVueloConMayorOcupacion(string codigoDeVuelo)
        {
            int cantPasajeros = 0;
            codigoDeVuelo = "";
            foreach (Clase_Vuelos vuelo in Vuelos)
            {
                if(cantPasajeros <= vuelo.CantPasajeros)
                {
                    cantPasajeros = vuelo.CantPasajeros;
                    codigoDeVuelo = vuelo.CodigoDeVuelo;
                }
            }

            return codigoDeVuelo;
        }

        public void BuscarVueloPorCodigo(string codigoDeVuelo)
        {
            bool i= false;

            foreach (Clase_Vuelos vuelo in Vuelos)
            {
                if (vuelo.CodigoDeVuelo == codigoDeVuelo)
                {
                     Console.WriteLine(vuelo.CodigoDeVuelo);

                    Console.WriteLine("Vuelo encontrado:");
                    Console.WriteLine($"Código: {vuelo.CodigoDeVuelo}");
                    Console.WriteLine($"Fecha y hora de salida: {vuelo.FechaSalida}");
                    Console.WriteLine($"Fecha y hora de llegada: {vuelo.FechaLlegada}");
                    Console.WriteLine($"Piloto: {vuelo.NombrePiloto}");
                    Console.WriteLine($"Copiloto: {vuelo.NombreCopiloto}");
                    Console.WriteLine($"Capacidad: {vuelo.CapacidadMax}");
                    Console.WriteLine($"Ocupación: {vuelo.CalcularPorcentajeOcupacion():F2}%");
                    i = true;
 
                } 
            }

            if (!i)
            {
                Console.WriteLine("Vuelo N° " + codigoDeVuelo + " no encontrado");
            }


        }

        public void ListarVuelosPorOcupacion()
        {
            List<Clase_Vuelos> vuelosOrdenados = Vuelos.OrderByDescending(v => v.CalcularPorcentajeOcupacion()).ToList();

            foreach (Clase_Vuelos vuelo in vuelosOrdenados)
            {
                Console.WriteLine($"{vuelo.CodigoDeVuelo} - Ocupación: {vuelo.CalcularPorcentajeOcupacion():F2}%");
            }
        }


    }
}
