using System;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrero unGuerrero = new Guerrero("Furia nocturna", "Jaime", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            
            Console.WriteLine(unGuerrero.Nombre);
            Console.WriteLine(unGuerrero.caminar());
            Console.WriteLine(unGuerrero.correr());
        }
    }
}