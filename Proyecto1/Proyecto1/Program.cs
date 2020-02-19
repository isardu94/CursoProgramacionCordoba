using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {

            //        //Declaracion de variable de tipo integer llamada "x".
            //    int x;
            //    //Inicialización de variable llamada "x" con el valor  4.
            //    x = 4;
            //    //Declaración e inicialización.
            //    int y = 3;
            //    float z = 8.5f;
            //    double w = 12.65d;
            //    char letra = 'A';
            //    string frase = "Hola mundo";
            //    bool booleanoFalso = false;
            //    bool booleanoVerdadero = true;
            //    Console.WriteLine(y);
            //    Console.WriteLine(z);
            //    Console.WriteLine(w);
            //    Console.WriteLine(letra);
            //    Console.WriteLine(frase);
            //    Console.WriteLine(booleanoFalso);
            //    Console.WriteLine(booleanoVerdadero);

            //    Console.Write("Escriba el primer número: ");
            //    int f = int.Parse(Console.ReadLine());
            //    Console.Write("Escriba el segundo número: ");
            //    int g = int.Parse(Console.ReadLine());
            //    Console.Write("La suma es: ");
            //    Console.WriteLine(f + g);
            //    Console.Write("La resta es: ");
            //    Console.WriteLine(f - g);
            //    Console.WriteLine("La multiplicacion es:");
            //    Console.WriteLine(f * g);
            //    Console.WriteLine("La división es:");
            //    Console.WriteLine(f / g);


            //    //Ejercicio de IF - ELSE

            //    Console.WriteLine("Escriba su edad");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age >= 65)
            //    {
            //        Console.WriteLine("Eres un viejales");
            //    }

            //    else if (age >= 18)
            //    {
            //        Console.WriteLine("Eres mayor de edad");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eres menor de edad");
            //    }


            //    //EJERCICIO DE NOTA DE EXAMEN

            //    Console.WriteLine("Introducir la nota");
            //    float note = float.Parse(Console.ReadLine());
            //    if (note <= 10 && note >= 0)
            //    {
            //        if (note <= 10 && note >= 9)
            //        {
            //            Console.WriteLine("Sobresaliente");
            //        }
            //        else if (note < 9 && note >= 7)
            //        {
            //            Console.WriteLine("Notable");
            //        }
            //        else if (note < 7 && note >= 6)
            //        {
            //            Console.WriteLine("Bien");
            //        }
            //        else if (note < 7 && note >= 5)
            //        {
            //            Console.WriteLine("Suficiente");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Suspenso");
            //        }

            //    }
            //   else Console.WriteLine("La nota no es válida");
            //}


            //EJERCICIO SWITCH

            Console.WriteLine("Introduzca su nota: ");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;

                default:
                    Console.WriteLine("No es un número reconocible");
                    break;
            }

            }
    }
}
