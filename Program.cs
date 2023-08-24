using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Parte I: Declaración y asignación de valores

            // Declarar una variable de tipo texto, capturando su valor desde la consola.
            Console.WriteLine("Departamento: ");
            string? departamento = Console.ReadLine();

            Console.WriteLine("Municipio: ");
            string? municipio = Console.ReadLine();

            Console.WriteLine("Ciudad: ");
            string? ciudad = Console.ReadLine();

            // Declarar dos variables de texto, asignando su valor desde la declaración
            string colonia = "Col. Fatima María";
            string colorCasa = "Cafe";

            // Declaración de dos variables de tipo enteras, asignando su valor desde consola.
            Console.WriteLine("Años de vivir en su residencia actual: ");
            int añosDeVivirCasa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Edad actual: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            // Declarar dos variables de tipo DateTime, asignando su valor desde la declaración.
            DateTime fechaNacimiento = new DateTime(2003, 12, 25);
            DateTime fechaActual = DateTime.Now;

            // Parte II: Aplicación de funciones a las variables

            // Función para comparar cadenas
            bool sonIguales = departamento.Equals(municipio, StringComparison.OrdinalIgnoreCase);

            // Función para concatenar texto
            string direccion = $"{ciudad}, {municipio}, {departamento}";

            // Función de mayúscula
            string ciudadEnMayusculas = ciudad.ToUpper();

            // Función de limpiado de cadena
            string textoConEspacios = "   Esto es un texto con espacioss   ";
            string textoLimpio = textoConEspacios.Trim();

            // Función de longitud de cadena
            int longitudColonia = colonia.Length;
            int longitudCiudad = ciudad.Length;

            // Función de formateo de fecha (mostrarla en dia/mes/año)
            string fechaNacimientoFormateada = fechaNacimiento.ToString("dd/MM/yyyy");
            string fechaActualFormateada = fechaActual.ToString("dd/MM/yyyy");

            // Adicionar 2 semanas a cada fecha ingresada
            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);

            // Comparar las fechas
            bool fecha1MayorQueFecha2 = fechaNacimiento > fechaActual;
            bool fecha1MenorQueFecha2 = fechaNacimiento < fechaActual;

            // Parte III: Impresión de valores en consola

            Console.WriteLine("\nPARTE I: Declaración y asignación de valores");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Colonia: " + colonia);
            Console.WriteLine("Color de casa: " + colorCasa);
            Console.WriteLine("Años de vivir en su residencia actual: " + añosDeVivirCasa);
            Console.WriteLine("Edad actual: " + edad);
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Fecha actual: {fechaActual.ToShortDateString()}");

            Console.WriteLine("\nPARTE II: Aplicación de funciones");
            Console.WriteLine("¿Departamento y municipio son iguales? " + sonIguales);
            Console.WriteLine("Dirección completa: " + direccion);
            Console.WriteLine("Ciudad en mayúsculas: " + ciudadEnMayusculas);
            Console.WriteLine("Texto limpio: " + textoLimpio);
            Console.WriteLine("Longitud de colonia: " + longitudColonia);
            Console.WriteLine("Longitud de ciudad: " + longitudCiudad);

            Console.WriteLine("\nPARTE III: Impresión de valores en consola");
            Console.WriteLine("Valores obtenidos de las funciones de fecha:");
            Console.WriteLine("Fecha de nacimiento formateada: " + fechaNacimientoFormateada);
            Console.WriteLine("Fecha actual formateada: " + fechaActualFormateada);
            Console.WriteLine($"Fecha de nacimiento + 2 semanas: {fechaNacimientoMas2Semanas.ToShortDateString()}");
            Console.WriteLine($"Fecha actual + 2 semanas: {fechaActualMas2Semanas.ToShortDateString()}");
            Console.WriteLine("Fecha de nacimiento es mayor que fecha actual: " + fecha1MayorQueFecha2);
            Console.WriteLine("Fecha de nacimiento es menor que fecha actual: " + fecha1MenorQueFecha2);


            //-Colocar en comentario su autoevaluación de una escala de 1-10.
            //Autoevaluacion 10 / 10

        }
    }
}