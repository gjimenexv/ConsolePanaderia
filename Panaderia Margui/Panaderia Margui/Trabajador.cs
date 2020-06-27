using System;

namespace Panaderia_Margui
{
    internal class Trabajador
    {
            public void Trabajo01()
            {
                var laOpcion = string.Empty;
            while (laOpcion != "x")
                {
                    DesplegarMenu();
                    laOpcion = LeaLaOpcion();
                }
            }

            private void DesplegarMenu()
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. Pan Dulce.");
                Console.WriteLine("2. Pan Dulce.");
                Console.WriteLine("3. Pan Artesanal.");
                Console.WriteLine("x.  Salir");
            }

            private string LeaLaOpcion()
            {
                string elResultado = Console.ReadLine().ToLower();
                return elResultado;
            }
    }
}