using System;

namespace TP6
{
        class Program
        {
            static void Main(string[] args)
            {
                int num, resto;
                int invertido = 0;
                Console.WriteLine("ingrese mayor a 0 un numero");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    while (num > 0)
                    {

                        resto = num % 10;
                        invertido = invertido * 10 + resto;
                        num = num / 10;

                    }
                    Console.WriteLine(invertido);

                }
                else
                    Console.WriteLine("no es un numero mayor a 0");
            }
        }
    }
