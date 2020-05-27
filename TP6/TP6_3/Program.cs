using System;

namespace TP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0;
            int i;
            int cuadrado = 2;
            do
            {
                Console.WriteLine("elija la opcion" + "\n 1-valor absoluto" + "\n 2-cuadrado"+ "\n 3-raiz cuadrada" + "\n 4-seno" + "\n 5-coseno");
                i=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese un numero");
                num = double.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        num = Math.Abs(num);
                        Console.WriteLine("el resultado del valor absoluto: " + num);
                        break;
                    case 2:
                        num = Math.Pow(num,cuadrado);
                        Console.WriteLine("el resultado del cuadrado: " + num);
                        break;
                    case 3:
                        num = Math.Sqrt(num);
                        Console.WriteLine("el resultado la raiz cuadrada: " + num);
                        break;
                    case 4:
                        num = Math.Sin(num);
                        Console.WriteLine("el resultado seno: " + num);
                        break;
                    case 5:
                        num = Math.Cos(num);
                        Console.WriteLine("el resultado coseno: " + num);
                        break;
                }
            }while(i == 0);
        }
    }
}
