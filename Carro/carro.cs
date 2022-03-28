using System;
using System.Collections.Generic;
using System.Text;

namespace Carro
{
   
internal class Carro
{
    public string Marca { get; }
    public int Modelo { get; }

    public String Color { get; set; }

    private int Encendido = 0;
    private int velocidad_actual = 0;
    private int MAXVELOCIDAD = 0;

    public Carro(string _marca, int _modelo, string _color, int _maxVeloc)
    {
        Marca = _marca;
        Modelo = _modelo;
        Color = _color;
        Encendido = 0;
            MAXVELOCIDAD = _maxVeloc;
        this.velocidad_actual = 0;
    }

    public string acelerar()
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += 10;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }

    public string acelerar(int AcekerarAkph)
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += AcekerarAkph;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }

    public string GetVelocidadActual()
    {
        return $"VAmos a {velocidad_actual}KPH";
    }


    public void EncenderMotor()
    {
        if (Encendido == 0)
        {
            Encendido = 1;
            Console.WriteLine("Brururururururu carro encendido!!");
            velocidad_actual = 0;

        }
        else
        {
            Console.WriteLine("ups el carro ya estaba encendido");
        }
    }

    public void DameInformacion()
    {
        Console.WriteLine($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
    }


        public void Frenar(int cantidad)

        {

            // Aquí se le dice a los frenos que actúen, y...

            Console.WriteLine("Reduciendo la velocidad en {0} km/h", cantidad);

            this.velocidad_actual -= cantidad;

        }


        public string desacelerar(int desacelerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual -= desacelerarAkph;
                mensaje = $"bajando velocidad {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual=velocidad_actual;
                mensaje = "tranquilo, vas a bajando velocidad!!";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }

        public void ApagarMotor()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                Console.WriteLine("LLegaste a tu destino motor apagado!!");
                velocidad_actual = 0;

            }
            else
            {
                Console.WriteLine("ups el carro ya estaba encendido");
            }
        }

        public void Bocinar()
        {
                Console.WriteLine("Piiiiiiiiit Piiiiiiiiiiit!");
            }
        

    }
}