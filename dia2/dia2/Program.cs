using System;

namespace dia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Introduce número 1");
            //int _numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce numero 2");
            //int _numero2 = int.Parse(Console.ReadLine());
            //int x = _numero1;
            //int y = _numero2;
            //if (x == y)
            //{
            //    Console.WriteLine("Son iguales.");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales.");
            //    if (y < x)
            //    {
            //        Console.WriteLine("El número 1 es mayor.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número 2 es mayor.");
            //    }
            //}

            //COMPROBACION DE NUMEROS PARES.__________________________________

            // Console.WriteLine("Introduce número 1");
            // int _numero1 = int.Parse(Console.ReadLine());
            // int x = _numero1;
            //if (x % 2 == 0 )
            // {
            //     Console.WriteLine("El número es par.");
            // }
            //else
            // {
            //     Console.WriteLine("El número es impar.");
            // }

            //COMPROBACION DE MULTIPLOS.__________________________________

            //Console.WriteLine("Introduce número 1");
            //int _numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce número 2");
            //int _numero2 = int.Parse(Console.ReadLine());
            //int x = _numero1;
            //int y = _numero2;

            //if (x % y == 0 || y % x == 0)
            //{
            //    Console.WriteLine("Es múltiplo.");
            //}
            //else
            //{
            //    Console.WriteLine("No es multiplo.");
            //}

            //COMPROBACION DE NUMEROS PARES.__________________________________

            //Console.WriteLine("Introduce número 1");
            //int _numero1 = int.Parse(Console.ReadLine());
            //int x = _numero1;
            //if (x == 0)
            //{
            //    Console.WriteLine("El número es 0.");
            //}
            //else
            //{
            //    if (x > 0)
            //{
            //    Console.WriteLine("El número positivo.");
            //}
            //else
            //{
            //    Console.WriteLine("El número es negativo.");
            //}
            //}

            //REFRÁN, CHISTE O INSULTO.

            //Console.WriteLine("Pulsa 1 para un refrán.");
            //Console.WriteLine("Pulsa 2 para un chiste.");
            //Console.WriteLine("Pulsa 3 para un insulto.");
            //int _option = int.Parse(Console.ReadLine());

            //switch (_option)
            //{

            //    case 1:
            //        Console.WriteLine("Mas vale pájaro en sombra que cobija que el cantaro en la fuente del ojo ajeno.");
            //        break;
            //    case 2:
            //        Console.WriteLine("¿Qué es un león sin cabeza? Un león muerto.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Cara murciélago.");
            //        break;
            //    case 69:
            //        Console.WriteLine("Guarrete.");
            //        break;
            //    default:
            //        Console.WriteLine("Tu eres subnormal.");
            //        break;

            //}

            ////NOTA MEDIA
            //Console.WriteLine("Introduzca su nota de inglés: ");
            //float _nota1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Introduzca su nota de matemáticas: ");
            //float _nota2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Introduzca su nota de lengua: ");
            //float _nota3 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Su nota media es: ");
            //float _notamedia = ((_nota1 + _nota2 + _nota3) / 3f);
            //Console.WriteLine(_notamedia);

            //JUICIO DE ALTURA

            //Console.WriteLine("Introduzca su altura en centímetros");
            //int _alt = int.Parse(Console.ReadLine());
            //if (_alt <= 0)
            //{
            //    Console.WriteLine("Que te acuestes. Di la verdad");
            //}
            //else
            //{

            //    if (_alt >= 190)
            //    {
            //        Console.WriteLine("Hostia cabrón, que alto eres.");
            //    }
            //    else if (_alt >= 175 && _alt < 190)
            //    {
            //        Console.WriteLine("ah si? Bueno bueno...");
            //    }
            //    else if (_alt < 175 && _alt >= 145)
            //    {
            //        Console.WriteLine("Eres un taponcete");
            //    }
            //    else if (_alt < 145 && _alt >= 0)
            //    {
            //        Console.WriteLine("No creo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No me tangues.");
            //    }

            //WHILE
            //int repetitions = int.Parse(Console.ReadLine());
            //int counter = 0;

            //while (counter < repetitions)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}


            //    }

            //TABLA MULTIPLICAR

            //    //WHILE
            //    Console.WriteLine("Introduce el numeroa multiplicar");
            //int _table = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce número de veces a repetir");
            //int _limit = int.Parse(Console.ReadLine());
            //int x = 0; 
            //while (x!=_limit)
            //{
            //    Console.WriteLine(_table * x);
            //    x++;
            //}

            //DO WHILE

            //int repetitions = int.Parse(Console.ReadLine());
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //while (counter < repetitions);

            //FOR

            Console.WriteLine("Escribe el numero a multiplicar");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el nº veces a repetir");
            int repetitions = int.Parse(Console.ReadLine());
            for (int i = 0; i <= repetitions; i +=1)
            {
                Console.WriteLine(x + "x" + i + " = " + (x * i));
            }

        }



        }

    }

