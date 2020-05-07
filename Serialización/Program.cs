using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialización
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Persona> people = new List<Persona>();

            IFormatter formatter = new BinaryFormatter();

            while (true) {
                String response;
                Console.WriteLine("Agregar Personas: {A}");
                Console.WriteLine("Ver Personas: {V}");
                Console.WriteLine("Cargar Personas: {C}");
                Console.WriteLine("Salir: {S}\n");
                response = Console.ReadLine();

                if (response == "A")
                {
                    String new_nombre;
                    String new_apellido;
                    String new_edad;
                    String almacenar;
                    Console.Write("Nombre de la persona nueva: ");
                    new_nombre = Console.ReadLine();
                    Console.Write("Apellido de la persona nueva: ");
                    new_apellido = Console.ReadLine();
                    Console.Write("Edad de la persona nueva: ");
                    new_edad = Console.ReadLine();

                    Persona person = new Persona(new_nombre, new_apellido, Convert.ToInt32(new_edad));
                    people.Add(person);

                    Console.Write("Desea almacenar esta persona?: {Y/N}");
                    almacenar = Console.ReadLine();

                    if(almacenar == "Y")
                    {
                        Stream stream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, person);
                        stream.Close();
                    }

                    almacenar = "x";
                }

                if (response == "V")
                {
                    foreach(Persona person in people)
                    {
                        Console.WriteLine(person);
                    }
                }

                if (response == "C")
                {
                    Stream stream = new FileStream("Person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Persona persona = (Persona)formatter.Deserialize(stream);
                    people.Add(persona);
                }

                if (response == "S")
                {
                    return;
                }

                response = "x";
            }
        }
    }
}
