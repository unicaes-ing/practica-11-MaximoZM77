using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Maximo Zamora 12/11/19
namespace Practica11
{
    class ejercicio3
    {
        public static void MenuInicial()
        {
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("==== MENU ====");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("1-Agregar datos del alumno");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("2-Mostrar datos del alumno");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("3-Buscar alumno");
            Console.SetCursorPosition(65, 18);
            Console.WriteLine("4-Salir del programa");
            Console.SetCursorPosition(65, 22);
            Console.Write("Opcion:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Ingresar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Presiona <ENTER> para salir del programa");
                    Console.ReadKey();
                    break;
            }
        }
        static void Main(string[] args)
        {
            MenuInicial();
            Console.ReadKey();
        }
        public static void Ingresar()
        {
            try
            {
                Console.WriteLine("==== Datos del alumno ====");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el carnet del alumno:");
                string carnetEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese nombre del alumno:");
                string nombreEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese la edad del alumno:");
                int edadEstudiante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingrese el CUM del alumno:");
                decimal cumEstudiante = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos_Alumno.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(carnetEstudiante);
                binario.Write(nombreEstudiante);
                binario.Write(edadEstudiante);
                binario.Write(cumEstudiante);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los datos se guardaron exitosamente...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al guardar los datos...");
            }
        }
        public static void Mostrar()
        {
            Console.WriteLine("==== MOSTRAR =====");
            Console.WriteLine();
            Console.WriteLine("1-Todos los alumnos");
            Console.WriteLine();
            Console.WriteLine("2-Filtrados por CUM");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Opcion: ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }
        public static void Buscar()
        {
        }
    }
}
