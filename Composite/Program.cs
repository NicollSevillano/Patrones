using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Componente cc = new Directorio("raiz");

            Componente archivo1 = new Archivo("archivo.txt", 10);
            Componente archivo2 = new Archivo("archivo2.txt", 30);
            Componente archivo3 = new Archivo("archivo3.txt", 120);
            Componente archivo4 = new Archivo("archivo4.txt", 800);
            Componente archivo5 = new Archivo("archivo5.txt", 340);

            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");

            dir1.agregarHijo(archivo1);
            dir2.agregarHijo(archivo2);
            dir3.agregarHijo(archivo3);
            dir3.agregarHijo(archivo4);
            dir1.agregarHijo(dir3);

            cc.agregarHijo(dir1);
            cc.agregarHijo(dir2);
            cc.agregarHijo(archivo5);

            Console.WriteLine($"El tamaño del directorio {cc.Nombre} es {cc.obtenerTamaño}");
            Console.WriteLine($"El tamaño del directorio {dir1.Nombre} es {dir1.obtenerTamaño}");
            Console.WriteLine($"El tamaño del directorio {dir2.Nombre} es {dir2.obtenerTamaño}");
            Console.WriteLine($"El tamaño del directorio {dir3.Nombre} es {dir3.obtenerTamaño}");

            Console.ReadKey();
        }
    }
}
