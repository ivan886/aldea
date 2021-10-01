namespace Herencia3
{
    public class Aldea
    {
        private string nombre;
        private string ubicacion;
        public Habitante[] habitantes = new Habitante[100];

     

        public Aldea(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getUbicacion()
        {
            return this.ubicacion;
        }

        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        



    }
}