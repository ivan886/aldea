using System;
using System.Runtime.Serialization.Json;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {                             ///instanciar
            Aldeano unAldeano = new Aldeano( "Eynar", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Guerrero unGuerrero = new Guerrero("Furia nocturna", "Marcos", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Guerrero dosGuerrero = new Guerrero("William ", "Jaime", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Aldea unaAldea = new Aldea("la aldea", "calle falsa 123 ");

            unaAldea.habitantes[0] = unAldeano;
            unaAldea.habitantes[1] = unGuerrero; 
            unaAldea.habitantes[2] = dosGuerrero;

           /*Imprimir la informacion de los diferentes habitantes*/
            foreach (Habitante unHabitante in unaAldea.habitantes)
            {  Console.WriteLine(unHabitante.Nombre);
                /*el objeto es un habitante  no podemos acceder a
                 funcionalidades especificas de acuerd a su tipo guerrero o aldeano 
                 para esto debemos conocer de que tipo de objeto se trata  
                 para realizar un cast y acceder a sus metodos y atributos caracteristicos*/
                if (unHabitante.GetType().Name.Equals("Guerrero"))
                { Console.WriteLine("Soy un Guerrero");
                   
                    var guerrero = (Guerrero) unHabitante;    
                    Console.WriteLine(guerrero.pelear());
                    Console.WriteLine( guerrero.defender());
                }
                else
                {  var aldeano = (Aldeano) unHabitante;
                    Console.WriteLine("Soy un Aldeano");
                    Console.WriteLine(aldeano.cultivar());
                }
            
                
                
            }
            
           
            
            
            
        }
    }
}