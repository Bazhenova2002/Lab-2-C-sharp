using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2_C_sharp
{

    class Program
    {
        static void Main(string[] args)
        {
            int storona;
            Console.WriteLine("Введите длину стороны :");
            storona = Convert.ToInt32(Console.ReadLine());
            Kvadrat kv1 = new Kvadrat(storona);

            Console.WriteLine(kv1.Info());
            Console.WriteLine("Area {0}", kv1.Area());
            Console.WriteLine("Perimeter {0}", kv1.Perimeter());
            Console.WriteLine("Diagonal {0}", kv1.Diagonal());
            Console.WriteLine();

            int visota;
            Console.WriteLine("Введите длину высоты :");
            visota = Convert.ToInt32(Console.ReadLine());
            Prizma pr1 = new Prizma(storona, visota);

            Console.WriteLine(pr1.Info());
            Console.WriteLine("Area {0}", pr1.Area());
            Console.WriteLine("Perimeter {0}", pr1.Perimeter());
            Console.WriteLine("Diagonal {0}", pr1.Diagonal());
            Console.WriteLine("Objom {0}", pr1.Objom());

            Console.ReadKey();
        }
    }
}