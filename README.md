# 📦 Order Processor Application

Este repositorio contiene una aplicación de procesamiento de órdenes simple que utiliza NLog para gestionar el logging de la aplicación. La aplicación está diseñada para leer un archivo de órdenes y procesar cada línea como una orden individual.

## 🌟 Características

- **Procesamiento de órdenes**: Lee y procesa órdenes desde un archivo de texto.
- **Logging robusto**: Utiliza NLog para registrar eventos de la aplicación, facilitando el seguimiento y la depuración.
- **Logs coloreados**: Configuración de consola coloreada para una fácil distinción de los niveles de log.

## ⚙️ Configuración de NLog

La configuración de NLog se gestiona a través del archivo `NLog.config`, que incluye especificaciones para:

- Log en archivos con rotación basada en tamaño y tiempo.
- Logs en consola con soporte de colores, lo que mejora la visibilidad de diferentes niveles de logs durante el desarrollo.

## 🚀 Cómo Empezar

Sigue estos pasos para configurar y ejecutar el proyecto localmente.

### 📋 Prerrequisitos

Asegúrate de tener instalado [.NET SDK](https://dotnet.microsoft.com/download) compatible con .NET 6 o superior.

### 📥 Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/tu-repositorio.git


2. Navega al directorio del proyecto:
    ```bash
    cd tu-repositorio


3. Para ejecutar la aplicación
    ```bash
    dotnet run

4. Para construir la aplicación:
    ```bash
    dotnet build
