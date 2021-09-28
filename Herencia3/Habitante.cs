using System;

namespace Herencia3
{
    public class Habitante
    {
        private string nombre;
        private char genero;
        private DateTime fechaNacimiento;
        private DateTime fechaFin;
        private string mestizaje;
        private string oficio;
        private string equipamiento;

        public Habitante(string nombre, char genero, DateTime fechaNacimiento, DateTime fechaFin, string mestizaje)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaFin = fechaFin;
            this.mestizaje = mestizaje;
        }


        public string correr()
        {
            return "estoy corriendo";
        }

        public string caminar()
        {
            return "estoy caminando ";
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public char Genero
        {
            get => genero;
            set => genero = value;
        }

        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public DateTime FechaFin
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public string Mestizaje
        {
            get => mestizaje;
            set => mestizaje = value;
        }

        public string Oficio
        {
            get => oficio;
            set => oficio = value;
        }

        public string Equipamiento
        {
            get => equipamiento;
            set => equipamiento = value;
        }
    }
}