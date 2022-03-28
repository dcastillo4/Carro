using System;

namespace Carro
{
    internal class Program
    {
  


        static void Main(string[] args)
        {

            Carro miCarrito = new Carro("Toyota", 2022, "azul", 200);
            Carro EstefaniCarrito = new Carro("Ferrari", 2022, "Rojo", 200);

            if (miCarrito.Modelo > EstefaniCarrito.Modelo)
            {
                Console.WriteLine("El carro del profe es mas reciente");
            }
            else
            {
                Console.WriteLine("El carro de Estefani es mas reciente");
            }

            //Console.WriteLine($"teacher car is {miCarrito.Marca}");
            Console.WriteLine($"Mi carrito es {miCarrito.Marca}");
            //Console.WriteLine($"Estafani's model car is {EstefaniCarrito.Modelo}");


            //EstefaniCarrito.EncenderMotor();
            Console.WriteLine(miCarrito.GetVelocidadActual());
            miCarrito.EncenderMotor();

            for (int i = 0; i < 5; i++)
            {
                miCarrito.acelerar();
            }

            miCarrito.acelerar(10);
            

            for (int i = 0; i < 5; i++)
            {
                miCarrito.desacelerar(10);
            }
            miCarrito.Bocinar();

            miCarrito.ApagarMotor();


            miCarrito.Frenar(10);
        }
    }
}
