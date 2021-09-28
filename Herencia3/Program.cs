using System;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aldeano unAldeano = new Aldeano( "Marcos", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Guerrero unGuerrero = new Guerrero("Furia nocturna", "Jaime", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            
            Console.WriteLine("CARACTERISTICAS ALDEANO ");
            Console.WriteLine(unAldeano.Nombre);
            Console.WriteLine(unAldeano.caminar());
            Console.WriteLine(unAldeano.correr());
            Console.WriteLine(unAldeano.cultivar());
            
            Console.WriteLine("CARACTERISTICAS GUERRERO ");
            Console.WriteLine(unGuerrero.Nombre);
            Console.WriteLine(unGuerrero.caminar());
            Console.WriteLine(unGuerrero.correr());
            Console.WriteLine(unGuerrero.pelear());
        }
    }
}