//Introducción

//Se necesita un sistema para gestionar la ocupación de los vuelos y las estadísticas de los mismos.
//El programa deberá tener un menú de opciones que permita agregar vuelos, registrar pasajeros, guardar
// y recuperar los datos y calcular estadísticas sobre la ocupación de los vuelos.

//Requisitos del sistema 
//Desarrollar un programa en C# que permita gestionar la ocupación y estadísticas de los vuelos de una aerolínea
//(razón social, teléfono, domicilio) mediante el uso de archivos XML para almacenar y cargar datos.
//El programa incluirá un menú de opciones para gestionar vuelos, registrar pasajeros, realizar cálculos sobre la ocupación, y encontrar vuelos específicos.

//Descripción de las funcionalidades: 

//Agregar un vuelo: Permite al usuario agregar un nuevo vuelo indicando su código de vuelo, fecha y hora de salida, fecha y hora de llegada,
//tripulantes de cabina (nombres de piloto y copiloto) y capacidad máxima.

//Registrar pasajeros en un vuelo: Permite al usuario ingresar el número de pasajeros que subieron a un vuelo específico (indicando su código de vuelo).

//Calcular ocupación media de la flota: Calcula el promedio de ocupación de todos los vuelos registrados.

//Vuelo con mayor ocupación: Identifica y muestra el vuelo que tiene el mayor porcentaje de ocupación.

//Buscar vuelo por código: Permite al usuario ingresar el código de un vuelo específico y muestra sus detalles si existe, junto con su porcentaje de ocupación.

//Listar vuelos ordenados por ocupación: Muestra todos los vuelos ordenados según su porcentaje de ocupación, de mayor a menor.

//Cargar datos: Guarda los datos en un archivo XML. Los datos deben recuperarse cada vez que se inicie el programa. 

//Aclaraciones
//Leer atentamente todo el trabajo práctico antes de comenzar a programar.
//Se debe implementar si o si archivos XML y programación orientada a objetos.
//No es necesario relacionar ese trabajo con los realizados previamente
//Subir el tp a GitHub y compartir el link. El repositorio debe ser público. 
//Añadan comentarios en el código para explicar la lógica detrás de alguna sección importante si lo consideran necesario. 
//Procuren que el programa sea interactivo y fácil de entender para el usuario.
//Se les solicita implementar al menos una función.
//Agregar un archivo READ.ME con la documentación. Incluir nombres y apellidos de los integrantes del grupo.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4;


namespace TP4
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Clase_Aerolinea aerolinea = new Clase_Aerolinea("AeroLin", "123-456-7890", "Calle Falsa 123");


            ArchivoXML archivoXML = new ArchivoXML("aerolinea.xml");


            aerolinea = archivoXML.CargarDatos() ?? aerolinea;


            Menu menu = new Menu(aerolinea, archivoXML);
            menu.MostrarMenu();

            Console.WriteLine("Gracias por usar el sistema de gestión de vuelos. ¡Hasta luego!");
        }
    }
}