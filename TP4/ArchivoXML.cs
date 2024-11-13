using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Xml.Serialization;

namespace TP4
{

    public class ArchivoXML
    {
        private readonly string rutaArchivo;

 
        public ArchivoXML(string ruta)
        {
            rutaArchivo = ruta;
        }


        public void GuardarDatos(Clase_Aerolinea aerolinea)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Clase_Aerolinea));
                    serializer.Serialize(writer, aerolinea); 
                    Console.WriteLine("Datos guardados exitosamente en el archivo XML.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar datos: " + ex.Message);
            }
        }


        public Clase_Aerolinea CargarDatos()
        {
            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Clase_Aerolinea));
                    Clase_Aerolinea aerolinea = (Clase_Aerolinea)serializer.Deserialize(reader);
                    Console.WriteLine("Datos cargados exitosamente desde el archivo XML.");
                    return aerolinea;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar datos: " + ex.Message);
                return null;
            }
        }
    }
}
