using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Menu
    {
        private Clase_Aerolinea aerolinea;
        private ArchivoXML archivoXML;


        public Menu(Clase_Aerolinea aerolinea, ArchivoXML archivo)
        {
            this.aerolinea = aerolinea;
            archivoXML = archivo;
        }

 
        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Menú de Gestión de Vuelos ---");
                Console.WriteLine("1. Agregar un vuelo");
                Console.WriteLine("2. Registrar pasajeros en un vuelo");
                Console.WriteLine("3. Calcular ocupación media de la flota");
                Console.WriteLine("4. Mostrar vuelo con mayor ocupación");
                Console.WriteLine("5. Buscar vuelo por código");
                Console.WriteLine("6. Listar vuelos ordenados por ocupación");
                Console.WriteLine("7. Guardar datos en XML");
                Console.WriteLine("8. Cargar datos desde XML");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    GestionarOpciones(opcion);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (opcion != 0);
        }

        private void GestionarOpciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    AgregarVuelo();
                    
                    break;
                case 2:
                    Console.Clear();
                    RegistrarPasajeros();
                    break;
                case 3:
                    Console.Clear();
                    CalcularOcupacionMedia();
                    break;
                case 4:
                    Console.Clear();
                    MostrarVueloConMayorOcupacion();
                    break;
                case 5:
                    Console.Clear();
                    BuscarVueloPorCodigo();
                    break;
                case 6:
                    Console.Clear();
                    ListarVuelosPorOcupacion();
                    break;
                case 7:
                    Console.Clear();
                    GuardarDatos();
                    break;
                case 8:
                   Console.Clear();
                    CargarDatos();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }


        private void AgregarVuelo()
        {
            Console.Write("Ingrese el código de vuelo: ");
            string codigo = Console.ReadLine();

            Console.Write("Fecha de salida (aaaa-mm-dd hh:mm): ");
            DateTime fechaSalida = DateTime.Parse(Console.ReadLine());

            Console.Write("Fecha de llegada (aaaa-mm-dd hh:mm): ");
            DateTime fechaLlegada = DateTime.Parse(Console.ReadLine());

            Console.Write("Nombre del piloto: ");
            string piloto = Console.ReadLine();

            Console.Write("Nombre del copiloto: ");
            string copiloto = Console.ReadLine();

            Console.Write("Capacidad máxima de pasajeros: ");
            int capacidad = int.Parse(Console.ReadLine());

            Clase_Vuelos nuevoVuelo = new Clase_Vuelos(codigo, fechaSalida, fechaLlegada, piloto, copiloto, capacidad);
            aerolinea.AgregarVuelo(nuevoVuelo);

            Console.WriteLine("Vuelo agregado exitosamente.");
        }

       
        private void RegistrarPasajeros()
        {
            Console.Write("Ingrese el código del vuelo: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el número de pasajeros a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Clase_Vuelos vuelo = aerolinea.Vuelos.FirstOrDefault(v => v.CodigoDeVuelo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
            if (vuelo != null)
            {
                if (vuelo.RegistrarPasajeros(cantidad))
                {
                    Console.WriteLine("Pasajeros registrados correctamente.");
                }
                else
                {
                    Console.WriteLine("No se pueden registrar más pasajeros. Capacidad máxima alcanzada.");
                }
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
        }

    
        private void CalcularOcupacionMedia()
        {
            double ocupacionMedia = aerolinea.CalcularOcupacionMedia();
            Console.WriteLine($"Ocupación media de la flota: {ocupacionMedia:F2}%");
        }

      
        private void MostrarVueloConMayorOcupacion()
        {
            string vueloCodigo = aerolinea.ObtenerVueloConMayorOcupacion("");
            if (!string.IsNullOrEmpty(vueloCodigo))
            {
                Console.WriteLine($"El vuelo con mayor ocupación es: {vueloCodigo}");
            }
            else
            {
                Console.WriteLine("No hay vuelos registrados.");
            }
        }

   
        private void BuscarVueloPorCodigo()
        {
            Console.Write("Ingrese el código del vuelo a buscar: ");
            aerolinea.BuscarVueloPorCodigo(Console.ReadLine());
        }

   
        private void ListarVuelosPorOcupacion()
        {
            Console.WriteLine("\nVuelos ordenados por ocupación:");
            aerolinea.ListarVuelosPorOcupacion();
        }

        private void GuardarDatos()
        {
            archivoXML.GuardarDatos(aerolinea);
            Console.WriteLine("Datos guardados exitosamente en XML.");
        }

     
        private void CargarDatos()
        {
            aerolinea = archivoXML.CargarDatos();
            Console.WriteLine("Datos cargados exitosamente desde XML.");
        }
    }
}
