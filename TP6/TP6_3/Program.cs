using System;

namespace TP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            int num_1, num_2, maximo, minimo;
            int cuadrado = 2;
            //ingresar el numero
            Console.WriteLine("Ingrese un numero");
            num = double.Parse(Console.ReadLine());
            //valor absoluto, cuadrado, raiz cuadrada, seno, coseno
            num = Math.Abs(num);
            Console.WriteLine("el resultado del valor absoluto: " + num);
            num = Math.Pow(num,cuadrado);
            Console.WriteLine("el resultado del cuadrado: " + num);
            num = Math.Sqrt(num);
            Console.WriteLine("el resultado la raiz cuadrada: " + num);
            num = Math.Sin(num);
            Console.WriteLine("el resultado seno: " + num);
            num = Math.Cos(num);
            Console.WriteLine("el resultado coseno: " + num);
            Console.WriteLine("\ningrese un numero");
            num_1= int.Parse(Console.ReadLine());
            Console.WriteLine("\ningrese otro numero");
            num_2 =int.Parse(Console.ReadLine());
            maximo = Math.Max(num_1,num_2);
            Console.WriteLine("el numero mayor es: " + maximo);
            minimo = Math.Min(num_1, num_2);
            Console.WriteLine("el numero menor es: " + minimo);


        }
    }
}
