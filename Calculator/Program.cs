namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           Практическая работа №1            ");
            Console.WriteLine("");
            int xx = 0;
            while (xx != 9)
            {
                Console.WriteLine("Введите, какую операцию нужно выполнить:");
                Console.WriteLine("1 - сложить.             2 - вычесть.");
                Console.WriteLine("3 - умножить.            4 - разделить.");
                Console.WriteLine("5 - возвести в степень.  6 - найти квадратный корень.");
                Console.WriteLine("7 - найти 1 процент.     8 - найти факториал.");
                Console.WriteLine("9 - завершить работу программы.");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5 || x == 6 || x == 7 || x == 8 || x == 9)
                {
                    if (x == 9)
                    {
                        xx = 9;
                    }
                    else
                    {
                        Console.WriteLine("Введите число");
                        float y = Convert.ToInt32(Console.ReadLine());
                        if (x == 1)
                        {
                            Console.WriteLine("Введите второе число:");
                            float z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(y + z);
                        }
                        else if (x == 2)
                        {
                            Console.WriteLine("Введите второе число:");
                            float z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(y - z);
                        }
                        else if (x == 3)
                        {
                            Console.WriteLine("Введите второе число:");
                            float z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(y * z);
                        }
                        else if (x == 4)
                        {
                            Console.WriteLine("Введите второе число:");
                            float z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(y / z);
                        }
                        else if (x == 5)
                        {
                            Console.WriteLine("Введите второе число:");
                            float z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Math.Pow(y, z));
                        }
                        else if (x == 6)
                        {
                            Console.WriteLine(Math.Sqrt(y));
                        }
                        else if (x == 7)
                        {
                            Console.WriteLine(y / 100);
                        }
                        else if (x == 8)
                        {
                            int v, v2 = 1;
                            for (v=1; v<=y; v++)
                            {
                                v2 = v2 * v;
                            }
                            Console.WriteLine(v2);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели несуществующую операцию.");
                }
            }
        }
    }
}