using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            /*double a, b, c, D, x1, x2, z1, z2, y1, y2, y3;
            Console.WriteLine("Введи значение a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи значение b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи значение c:");
            c = double.Parse(Console.ReadLine());
            D = (b * b) - (4 * a * c);

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1={0} \nx2={1}", x1, x2);
            }
            if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Дискриминант равен нулю, уравнение имеет 1 корень: \nx={0}", x1);
            }
            if (D < 0)
            {
                z1 = Math.Sqrt(D * (-1));
                z2 = Math.Sqrt(D * (-1));
                y1 = -b / 2 * a;
                y2 = z1 / 2 * a;
                y3 = -z2 / 2 * a;
                Console.WriteLine("Дискриминант меньше нуля => \nx1={0}+{1}*i \nx2={0}+({2})*i", y1, y2, y3);
            }*/

            //Задание 2

            /*int kol, i;
            double sum, znam, d;
            Console.WriteLine("Введите количество слагаемых:");
            kol = int.Parse(Console.ReadLine());
            znam = 4;
            while (kol < 1)
            {
                Console.WriteLine("Не хватает слагаемых, введите другое количество:");
                kol = int.Parse(Console.ReadLine());
            }
            if (kol == 1)
            {
                Console.WriteLine("Число ПИ по формуле с количеством слагаемых 1 равно: \n" + znam);
            }
            sum = 1;
            i = 1;
            d = 3;
            while (i <= kol)
            {
                sum = sum - (1 / d) + (1 / (d + 2));
                d += 4;
                i++;
            }
            znam = sum * 4;
            Console.WriteLine("Пи по формуле с количеством слагаемых {0} равняется: \n{1}", kol, znam);*/

            //Задание 3

            /*int f0 = 0;
            int f1 = 1;
            int i = 0;
            while (f1 < 10000)
            {
                int f = f0 + f1;
                f0 = f1;
                f1 = f;
                if ((f / 1000) >= 1 && (f / 1000) < 10)
                {
                    i++;
                }

            }
            Console.WriteLine("Количество четырехзначных чисел в ряде Фибоначчи: {0}", i);*/

            //Задание 4

            /*double x, q;

            Console.WriteLine("Введите число x (градусы):");
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Ошибка. Попробуйте еще раз:");

            x = Math.PI / 180 * Math.Abs(x);
            Console.WriteLine("Введите число q:");
            while (!double.TryParse(Console.ReadLine(), out q) && q < 0 && q > 1)
                Console.WriteLine("Ошибка. Попробуйте еще раз (от 0 до 1):");

            int Fact(int n)
            {
                int factorial = 1;
                for (int i = 2; i < n + 1; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }

            double term = 1;
            int counter = 0;
            double cos = 0;
            int sign = -1;
            for (int i = 2; Math.Abs(term) >= q; i += 2)
            {
                cos += term;
                term = (Math.Pow(x, i) / Fact(i)) * sign;
                sign = -sign;
                counter++;

            }
            Console.WriteLine($"значение косинуса:{cos}\nПосчитано с помощью {counter} слагаемых ");*/

            //Задание 5

            /*int N, isH = 0;
            Console.WriteLine("Введите натуральное число:");
            while (!int.TryParse(Console.ReadLine(), out N) && N <= 0)
                Console.WriteLine("Ошибка. Попробуйте еще раз.\nВведите натуральное число:");

            for (int x = 1; x < N; x++)
            {
                for (int y = 1; y < N; y++)
                {
                    for (int z = 1; z < N; z++)
                    {
                        if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
                        {
                            Console.WriteLine($"{Math.Pow(x, 3)} + {Math.Pow(y, 3)} + {Math.Pow(z, 3)} = {N}");
                            isH++;
                        }
                    }
                }
            }
            if (isH == 0)
                Console.WriteLine("No such combinations!");*/

            //Задание 6

            int unit, year;
            Console.WriteLine("Введите год:");
            while (!int.TryParse(Console.ReadLine(), out year) && year < 0 && year > 100)
                Console.WriteLine("Ошибка. Попробуйте еще раз:"); 
            unit = year % 10;
            if (unit == 1 && year != 11)
                Console.WriteLine(year + " год");
            else if (unit > 0 && unit < 5 && (year < 10 || year > 20))
                Console.WriteLine(year + " года");
            else
                Console.WriteLine(year + " лет");
        }
    }
}
