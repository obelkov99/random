using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)

        {
           
            try
            {
                Console.WriteLine("Введите первое число:");
                double a = Vvod();
                Console.WriteLine("Введите второе число:");
                double b = Vvod();
                Console.WriteLine("Введите третье число:");
                double c = Vvod();
                Console.WriteLine("Среднее число:");
                Console.WriteLine(MiddleOf(a, b, c));
                Console.WriteLine("Минимум:");
                Console.WriteLine(Minimum(a, b, c));

                try
                {
                    double z = MiddleOf(a, b, c) / Minimum(a, b, c);
                    if (Minimum(a, b, c) < 0.00000000001)
                        Console.WriteLine("Деление на ноль. Ошибка.");
                    else
                    Console.WriteLine("Ответ " +z);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка. Введите другие числа");
                }



            }

            
            catch (Exception)
            { 
                Console.WriteLine("Ошибка. Введите другие числа");
            }

            
        }


                static public double MiddleOf(double a, double b, double c)
            {
                if (a < b)
                {
                    if (b < c)
                    {
                        return b;
                    }
                    else if (a > c)
                    {
                        return a;
                    }
                    else return c;
                }
                else if (a > b)
                {
                    if (a < c)
                    {
                        return a;
                    }
                    else if (b > c)
                    {
                        return b;
                    }
                    else return c;
                }
                else return a;


            }
            static double Vvod()
            {
            double Div = double.Parse(Console.ReadLine());
                return Div;
            }

            static public double Minimum(double a, double b, double c)
            {

                if (a < b) if (a < c) return a;
                    else return c;
                else if (b < c) return b;
                return c;
            }
        }
    }

