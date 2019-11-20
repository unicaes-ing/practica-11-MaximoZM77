using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Maximo Zamora 12/11/19
namespace Practica11
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("Datos_Cliente.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nombreCliente = binario.ReadString();
                string telCliente = binario.ReadString();
                string nacimientoCliente = binario.ReadString();
                decimal sueldoCliente = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("==== Datos del cliente ====");
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente: {0}", nombreCliente);
                Console.WriteLine();
                Console.WriteLine("Numero de telefono del cliente: {0}", telCliente);
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento del cliente: {0}", nacimientoCliente);
                Console.WriteLine();
                Console.WriteLine("Salario del cliente: {0:C2}", sueldoCliente);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presione <ENTER> para salir");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al guardar los datos");
            }
        }
    }
}
