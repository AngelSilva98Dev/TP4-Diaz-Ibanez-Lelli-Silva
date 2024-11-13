# ✈️ Trabajo Práctico de Gestión de Vuelos

## 📋 Descripción General
Este proyecto tiene como objetivo desarrollar un sistema de gestión de ocupación y estadísticas de vuelos de una aerolínea. El programa está implementado en C# y utiliza archivos XML para almacenar y recuperar los datos. La aplicación incluye un menú interactivo para agregar vuelos, registrar pasajeros, y calcular diversas estadísticas relacionadas con la ocupación.

## 🛠️ Funcionalidades Principales

1. **✍️ Agregar un vuelo**:
   - Permite al usuario registrar un nuevo vuelo especificando:
     - Código de vuelo.
     - Fecha y hora de salida.
     - Fecha y hora de llegada.
     - Tripulantes de cabina (nombres de piloto y copiloto).
     - Capacidad máxima de pasajeros.

2. **🧑‍🤝‍🧑 Registrar pasajeros en un vuelo**:
   - Permite al usuario registrar el número de pasajeros que subieron a un vuelo específico mediante su código de vuelo.

3. **📊 Calcular ocupación media de la flota**:
   - Calcula y muestra el promedio de ocupación de todos los vuelos registrados.

4. **🏆 Vuelo con mayor ocupación**:
   - Identifica y muestra el vuelo que tiene el mayor porcentaje de ocupación.

5. **🔍 Buscar vuelo por código**:
   - Permite al usuario buscar un vuelo mediante su código y muestra sus detalles, incluyendo su porcentaje de ocupación.

6. **📄 Listar vuelos ordenados por ocupación**:
   - Muestra todos los vuelos registrados ordenados de mayor a menor según su porcentaje de ocupación.

7. **💾 Cargar y guardar datos desde/para un archivo XML**:
   - Al iniciar el programa, los datos se cargan desde un archivo XML.
   - Permite guardar los datos de los vuelos en un archivo XML.

## 💻 Tecnologías Utilizadas
- **Lenguaje de programación**: C#
- **Formato de almacenamiento**: XML
- **Paradigma de programación**: Programación Orientada a Objetos (POO)

## 🛂 Estructura del Proyecto
El proyecto está organizado de la siguiente manera:
- **Clases**:
  - Clase `Vuelo`: Representa un vuelo con atributos como código de vuelo, fechas de salida y llegada, tripulación, y capacidad máxima.
  - Clase `GestorDeVuelos`: Contiene la lógica para gestionar la lista de vuelos, calcular ocupaciones, y manejar la persistencia de datos.

## 🛠️ Instrucciones de Ejecución
1. **Compilar y ejecutar**:
   - Abre el proyecto en un entorno de desarrollo compatible con C# (por ejemplo, Visual Studio).
   - Compila y ejecuta el proyecto.
2. **📖 Interacción con el menú**:
   - Sigue las instrucciones en pantalla para navegar por el menú y utilizar las diferentes funcionalidades.

## 💡 Comentarios y Explicaciones en el Código
Se han agregado comentarios en el código fuente para explicar la lógica en secciones importantes y facilitar la comprensión del mismo.

## 📂 Documentación de Archivos
- **`README.md`**: Documentación principal del proyecto.
- **Archivos XML**: Utilizados para almacenar y cargar la información de los vuelos.

## ⚠️ Consideraciones
- Es importante asegurarse de que el archivo XML exista y tenga el formato correcto antes de iniciar el programa.
- Se recomienda revisar y probar todas las funcionalidades antes de la entrega.

## 👥 Integrantes del Grupo
- [Nombre del Integrante 1]
- [Nombre del Integrante 2]
- [Nombre del Integrante 3]

## 🔗 Repositorio de GitHub
Puedes encontrar el código fuente en el siguiente enlace: [Enlace al repositorio](#).

---
Este proyecto fue desarrollado para demostrar habilidades en el uso de C#, manejo de archivos XML y aplicación de principios de POO. Esperamos que este sistema facilite la gestión y análisis de la ocupación de vuelos de una aerolínea.

