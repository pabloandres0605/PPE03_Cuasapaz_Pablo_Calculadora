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
├── Calculadora/
│   ├── Form1.cs              # Lógica de la calculadora
│   ├── Form1.Designer.cs     # Diseño de la interfaz (generado por Visual Studio)
│   ├── Program.cs            # Punto de entrada de la aplicación
│   └── Calculadora.csproj    # Archivo de configuración del proyecto
├── imagenes/                 # Capturas de pantalla
├── Calculadora.sln           # Solución de Visual Studio
├── README.md                 # Documentación
└── .gitignore                # Archivos excluidos (bin, obj, .vs)

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

