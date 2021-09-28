using System;

namespace Herencia3
{
    public class Guerrero:Habitante
    {
        private string nombreGuerrero;

        public Guerrero(string nombreGuerrero,string nombre, char genero, DateTime fechaNacimiento, DateTime fechaFin, string mestizaje) : base(nombre, genero, fechaNacimiento, fechaFin, mestizaje)
        {
            this.nombreGuerrero = nombreGuerrero;
        }

        public string pelear()
        {
            return "estoy peleando ";
        }

        public string defender()
        {
            return "estoy defendiendo";
        }


    }
}