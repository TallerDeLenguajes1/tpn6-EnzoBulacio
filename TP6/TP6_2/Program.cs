using System;

namespace TP1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2;
            string s1;
            do
            {

                Console.WriteLine("elija una opcion" + "\n 1-Suma" + "\n 2-resta" + "\n 3-multiplicacion" + "\n 4-division");
                i = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese un numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese otro numero");
                num2 = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:

                        num1 = num1 + num2;
                        Console.WriteLine("Resultado de la suma es: " + num1);
                        break;
                    case 2:
                        num1 = num1 - num2;
                        Console.WriteLine("Resultado de la resta es: " + num1);
                        break;
                    case 3:
                        num1 = num1 * num2;
                        Console.WriteLine("Resultado de la multiplicacion es: " + num1);
                        break;
                    case 4:
                        num1 = num1 / num2;
                        Console.WriteLine("Resultado de la division es: " + num1);
                        break;
                    default:
                        Console.WriteLine("no ha seleccionado ninguna opcion" + num1);
                        break;
                }
                Console.WriteLine("desea seguir operando S/N");
                s1 = Console.ReadLine();
            } while ((s1 == "S") || (s1 == "s"));
        }
    }
}
