using System;
using System.Runtime.Serialization;

namespace Serialización
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(String nombre, String apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }
}
