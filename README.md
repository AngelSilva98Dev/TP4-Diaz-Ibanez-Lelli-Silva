# ✈️ Sistema de Gestión de Vuelos

## 📝 Descripción
Este es un sistema de gestión para una aerolínea que permite registrar vuelos, calcular la ocupación de los vuelos y generar estadísticas sobre la flota. Los datos de los vuelos y la aerolínea se guardan y cargan mediante archivos XML para la persistencia de la información.

## 🚀 Funcionalidades
El sistema ofrece las siguientes funcionalidades:

1. **➕ Agregar un vuelo**: Permite al usuario agregar un nuevo vuelo con información como el código de vuelo, la fecha y hora de salida, la fecha y hora de llegada, el nombre del piloto y copiloto, y la capacidad máxima.
   
2. **👥 Registrar pasajeros en un vuelo**: Permite ingresar el número de pasajeros que suben a un vuelo específico.

3. **📈 Calcular ocupación media de la flota**: Calcula el promedio de ocupación de todos los vuelos registrados en la aerolínea.

4. **🏅 Obtener el vuelo con mayor ocupación**: Muestra el vuelo con el mayor porcentaje de ocupación.

5. **🔍 Buscar un vuelo por código**: Permite al usuario ingresar el código de un vuelo y muestra los detalles de dicho vuelo.

6. **📋 Listar vuelos por ocupación**: Muestra todos los vuelos ordenados según su porcentaje de ocupación, de mayor a menor.

7. **💾 Persistencia de datos**: Los datos de vuelos y la aerolínea se guardan y cargan mediante un archivo XML. Si el archivo existe, los datos se cargan al iniciar el programa. Si no, se crea un nuevo archivo cuando se guardan los datos.

## 💻 Tecnologías utilizadas
- 🖥️ **C#**
- 📂 **Archivos XML para persistencia de datos**
- 🧑‍💻 **Programación orientada a objetos**

## 🏗️ Estructura del proyecto

- **🛫 Clase_Aerolinea**: Contiene la información de la aerolínea (razón social, teléfono, domicilio) y una lista de vuelos. Proporciona métodos para agregar vuelos, calcular la ocupación media, obtener el vuelo con mayor ocupación, buscar vuelos y listar vuelos por ocupación.
  
- **✈️ Clase_Vuelos**: Representa un vuelo con información como el código del vuelo, la fecha y hora de salida y llegada, el nombre del piloto y copiloto, la capacidad máxima y el número de pasajeros registrados. Proporciona métodos para registrar pasajeros y calcular el porcentaje de ocupación.

- **📄 ArchivoXML**: Se encarga de la lectura y escritura de los datos en un archivo XML. Permite guardar los datos de la aerolínea y cargar los datos desde un archivo previamente guardado.

- **📑 Menu**: Muestra el menú interactivo al usuario y gestiona las opciones seleccionadas, llamando a los métodos correspondientes en Clase_Aerolinea.

- **💡 Program**: Contiene el punto de entrada (Main), donde se inicia el sistema, se cargan los datos desde XML (si existen) y se muestra el menú de opciones.

## 📚 Instrucciones de uso

### ⚙️ Requisitos previos
- Tener instalado **.NET Core** o **.NET Framework**.
- Un editor de texto o IDE como **Visual Studio** o **Visual Studio Code**.

### 🛠️ Clonar el repositorio
Puedes clonar el repositorio usando el siguiente comando:

```bash
git clone https://github.com/tu_usuario/tu_repositorio.git
```

##Participantes
   - **Diaz Francisco
   - **Ibañez Pablo
   - **Lelli Fabrizio
   - **Silva Angel

