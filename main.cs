using System;

public class CalculeISR
{

    public struct escala
    {
        public const double min = 416220.01;
        public const double med = 624329.01;
        public const double alt = 867123.00;
    }

    public struct porcentaje
    {
        public const double min = 0.15;
        public const double med = 0.20;
        public const double alt = 0.25;
    }

    public struct sumando
    {
        public const double min = 0;
        public const double med = 31216.00;
        public const double alt = 79776.00;
    }

    public static void Main(string[] args)
    {

        double sueldoAnual = 0;
        double IsrTotal = 0;
        double excedente = 0;
        Console.WriteLine("Introduce tu sueldo mensual");
        try
        {
            double sueldo = Double.Parse(Console.ReadLine());
            if (sueldo < 0)
            {
                {
                    Console.WriteLine("Monto Invalido");
                }

            }
            else
            {
                sueldoAnual = sueldo * 12;

                if (sueldoAnual <= escala.min)
                {
                    IsrTotal = 0;
                    Console.WriteLine("El ISR a pagar es: " + IsrTotal);
                }
                else if (sueldoAnual > escala.min && sueldoAnual <= escala.med)
                {
                    excedente = sueldoAnual - escala.min;
                    IsrTotal = ((excedente * porcentaje.min) + sumando.min) / 12;
                    Console.WriteLine("El ISR a pagar es: $RD " + Math.Round(IsrTotal, 1));
                }
                else if (sueldoAnual > escala.med && sueldoAnual <= escala.alt)
                {
                    excedente = sueldoAnual - escala.med;
                    IsrTotal = ((excedente * porcentaje.med) + sumando.med) / 12;
                    Console.WriteLine("El ISR a pagar es: $RD  " + Math.Round(IsrTotal, 1));

                }
                else if (sueldoAnual > escala.alt)
                {
                    excedente = sueldoAnual - escala.alt;
                    IsrTotal = ((excedente * porcentaje.alt) + sumando.alt) / 12;
                    Console.WriteLine("El ISR a pagar es: $RD " + Math.Round(IsrTotal, 1));
                }

                Environment.Exit(0);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Entrada Invalida, Favor ingrese una cantidades numericas");
        }
        finally
        {
            Console.WriteLine("Intentelo Nuevamente");
        }

        Environment.Exit(0);


    }
}

