using System;
using System.Runtime.Serialization.Json;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aldeano unAldeano = new Aldeano( "Eynar", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Guerrero unGuerrero = new Guerrero("Furia nocturna", "Marcos", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Guerrero dosGuerrero = new Guerrero("Furia nocturna", "Jaime", 'm', new DateTime(1700,02,12 ),new DateTime(1700,02,12 ),"blanco"  );
            Aldea unaAldea = new Aldea();

            unaAldea.habitantes[0] = unAldeano;
            unaAldea.habitantes[1] = unGuerrero; 
            unaAldea.habitantes[2] = dosGuerrero;

           /*Imprimir la informacion de los diferentes habitantes*/
            foreach (Habitante obj in unaAldea.habitantes)
            {  Console.WriteLine(obj.Nombre);
                
                /*el objeto es un habitante  no podemos acceder a
                 funcionalidades especificas de acuerd a su tipo guerrero o aldeano 
                 para esto debemos conocer de que tipo de objeto se trata  
                 para realizar un cast y acceder a sus metodos y atributos caracteristicos*/
                if (obj.GetType().Name.Equals("Guerrero"))
                { Console.WriteLine("Soy un Guerrero");
                   
                    var guerrero = (Guerrero) obj;    
                    
                    guerrero.pelear();
                }
                else
                {var aldeano = (Aldeano) obj;
                    Console.WriteLine("Soy un Aldeano");
                    aldeano.cultivar();
                }
            
                
                
            }
            
           
            
            
            
        }
    }
}