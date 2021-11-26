using System;

namespace indi1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            /*int ax, ay, bx, by;
            int a = 0;
            int b = 0;
            Console.WriteLine("Введите координаты x для точки A");
            ax = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y для точки A");
            ay = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x для точки B");
            bx = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y для точки B");
            by = int.Parse(Console.ReadLine());
            if (ax == 0 || ay == 0)
                Console.WriteLine("Zero coord");
            if (bx == 0 || by == 0)
                Console.WriteLine("Zero coord");

            if (ax > 0 && ay > 0)
            {
                Console.WriteLine("Точка А в 1 четверти");
                a = 1;
            }
            else
                if (ax < 0 && ay > 0)
            {
                Console.WriteLine("Точка А в 2 четверти");
                a = 2;
            }
            else
                    if (ax < 0 && ay < 0)
            {
                Console.WriteLine("Точка А в 3 четверти");
                a = 3;
            }
            else
                        if (ax > 0 && ay < 0)
            {
                Console.WriteLine("Точка А в 4 четверти");
                a = 4;
            }


            if (bx > 0 && by > 0)
            {
                Console.WriteLine("Точка B в 1 четверти");
                b = 1;
            }
            if (bx < 0 && by > 0)
            {
                Console.WriteLine("Точка B в 2 четверти");
                b = 2;
            }
            if (bx < 0 && by < 0)
            {
                Console.WriteLine("Точка B в 3 четверти");
                b = 3;
            }
            if (bx > 0 && by < 0)
            {
                Console.WriteLine("Точка B в 4 четверти");
                b = 4;
            }
            if (a == b)
            {
                Console.WriteLine("Четверти совпали. true");
            }
            if (a != b)
            {
                Console.WriteLine("Четверти не совпали. false");
            }*/

            //Задание 2

            int a;
            int b = 3;
            Console.WriteLine("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a > 100000 || a == 0 || a < 0)
                Console.Write("Ошибка ввода! Введите число от 1 до 100000: ");
            for (; a != 1 && a % b == 0; a /= b) ;
            Console.WriteLine(a == 1);
        }
    }
}
