using System;

namespace Serialización
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true) {
                String response;
                Console.WriteLine("Agregar Personas: {A}");
                Console.WriteLine("Ver Personas: {V}");
                Console.WriteLine("Cargar Personas: {C}");
                Console.WriteLine("Salir: {S}\n");
                response = Console.ReadLine();

                if (response == "A")
                {
                    return;
                }

                if (response == "V")
                {
                    return;
                }

                if (response == "C")
                {
                    return;
                }

                if (response == "S")
                {
                    return;
                }
            }

        }
    }
}
