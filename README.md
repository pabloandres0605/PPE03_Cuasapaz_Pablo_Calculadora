## 1. Nombre del proyecto: 
PPE03_Cuasapaz_Pablo_Calculadora

## 2. Descripción general: 
Aplicación de escritorio tipo calculadora desarrollada en C# con Windows Forms. 
Permite realizar operaciones aritméticas básicas mediante una interfaz gráfica sencilla, 
con validación de entradas incorrectas.

## 3. Objetivos
•	Crear un proyecto de escritorio utilizando .NET Windows Forms.
•	Diseñar interfaces gráficas mediante controles visuales.
•	Gestionar eventos asociados a botones y otros controles.
•	Implementar operaciones aritméticas básicas.
•	Validar entradas y gestionar situaciones excepcionales, como la división para cero.
•	Organizar y documentar un proyecto de software utilizando GitHub.

## 4.Características principales
• Suma, resta, multiplicación y división.
• Botones numéricos del 0 al 9 que comparten un único evento (`BotonNumero_Click`).
• Botón igual (`=`) para mostrar el resultado.
• Botón limpiar (`C`) para reiniciar la calculadora.
• Operaciones encadenadas (por ejemplo `5 + 3 + 2`).
• Pantalla de solo lectura con alineación a la derecha.
• Validaciones: primer número obligatorio, segundo número obligatorio, conversión segura con `double.TryParse()`, 
control de división para cero, límite de 15 dígitos y control de resultados fuera de rango.
• Mensajes de error comprensibles mediante `MessageBox`.

## 5. Tecnologías utilizadas
• Lenguaje: C#
• Plataforma: .NET Framework 4.8 / .NET 8
• Interfaz: Windows Forms
• IDE: Visual Studio 2022
• Control de versiones: Git y GitHub

## 6.Requisitos de instalación
• Windows 10 u 11.
• Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET**.
•Git instalado

## 7.Instrucciones de ejecución
  1. Clonar el repositorio:
    ```bash
    git clone [https://github.com/pabloandres0605/PPE03_Cuasapaz_Pablo_Calculadora.git](https://github.com/pabloandres0605/PPE03_Cuasapaz_Pablo_Calculadora.git)

  2. Abrir la carpeta clonada y hacer doble clic en Calculadora.sln.
  3. Esperar a que Visual Studio cargue el proyecto.
  4. Compilar y ejecutar

## 8. Estructura del proyecto

PPE03_Cuasapaz_Pablo_Calculadora/
│
├── Calculadora/                  # Carpeta principal del proyecto de C# Windows Forms

│   ├── Properties/               # Contiene la configuración de propiedades y recursos del ensamblado

│   ├── App.config                # Archivo de configuración de la aplicación .NET

│   ├── Calculadora.csproj        # Archivo de proyecto de C# (contiene referencias, dependencias y rutas de compilación)

│   ├── Form1.Designer.cs         # Código generado automáticamente por el diseñador visual para los controles de la interfaz

│   ├── Form1.cs                  # Archivo de código lógica (Code-behind) donde se implementan los eventos y operaciones de la calculadora

│   ├── Form1.resx                # Archivo de recursos XML asociado al formulario (iconos, textos localizados, etc.)

│   └── Program.cs                # Punto de entrada principal donde se inicia la ejecución del hilo de la aplicación

│
├── imagenes/                     # Directorio para almacenar recursos gráficos y capturas de pantalla de la interfaz

├── .gitattributes                # Archivos de configuración para normalizar saltos de línea en Git

├── .gitignore                    # Especifica las carpetas y archivos temporales (como bin/ y obj/) que Git debe ignorar

├── Calculadora.sln               # Archivo de solución de Visual Studio que agrupa y vincula los proyectos de la solución

└── README.md                     # Documentación general del repositorio y guía de ejecución del proyecto



## 9. Capturas de pantalla
Carpeta Imagenes

## 10. Pruebas realizadas

a) Escenario: 8 + 3 =
Resultado esperado: Muestra 11
Resultado: Correcto

b) Escenario: 20 / 4 =
Resultado esperado: Muestra 5
Resultado: Correcto

c) Escenario: 5 / 0 =
Resultado esperado: Mensaje "No es posible dividir para cero."
Resultado: Correcto

d) Escenario: Presionar = sin ingresar el segundo número
Resultado esperado: Mensaje "Ingrese el segundo número."
Resultado: Correcto

e) Escenario: Escribir más de 15 dígitos
Resultado esperado: Mensaje indicando el límite máximo de dígitos
Resultado: Correcto

f) Escenario: Presionar el botón C (Limpiar)
Resultado esperado: Reinicia la pantalla a 0 y borra las variables
Resultado: Correcto

## 11. Autor:
Pablo Cuasapaz 

