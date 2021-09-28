using System;

namespace Herencia3
{
    public class Aldeano:Habitante
    {
        public Aldeano(string nombre, char genero, DateTime fechaNacimiento, DateTime fechaFin, string mestizaje) : base(nombre, genero, fechaNacimiento, fechaFin, mestizaje)
        {
        }

        public string cultivar()
        {
            return "estoy cultivando";
        }

        public string edificar()
        {
            return "estoy edificando";
        }

    }
}