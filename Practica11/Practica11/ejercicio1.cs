using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Maximo Zamora 12/11/19
namespace Practica11
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("==== Datos del Cliente ====");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el nombre del cliente:");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el numero de telefono del cliente:");
                string telCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese la fecha de nacimiento del cliente:");
                string nacimientoCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el salario del cliente:");
                decimal sueldoCliente = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos_Cliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombreCliente);
                binario.Write(telCliente);
                binario.Write(nacimientoCliente);
                binario.Write(sueldoCliente);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los datos fueron guardados exitosamente...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al guardar los datos...");
            }
        }
    }
}
