using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Main
    {
        string nazvanie;
        int index;
        string gorod;
        string ulitsa;
        int nomer;
        public string Nazvanie
        {
            get
            {
                return nazvanie;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Название организации введено некорректно");
                else
                    nazvanie = value;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Индекс введен некорректно");
                else
                    index = value;
            }
        }

        public string Gorod
        {
            get
            {
                return gorod;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Название города введено некорректно!");
                else
                    gorod = value;
            }
        }
        public string Ulitsa
        {
            get
            {
                return ulitsa;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Название улицы введено некорректно!");
                else
                    ulitsa = value;
            }
        }
        public int Nomer
        {
            get
            {
                return nomer;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Номер дома введен некорректно!");
                else
                    nomer = value;
            }
        }
        class Program
        {
            static Int32 Vvod()
            {
                Int32 Div = Int32.Parse(Console.ReadLine());
                return Div;
            }
            static string Vvod1()
            {
                string Div = Console.ReadLine();
                return Div;
            }
            static void Main(string[] args)
            {
                Console.WriteLine(" Задача: Построить описание класса, содержащего информацию о почтовом адресе организации. \n Предусмотреть возможность раздельного изменения составных частей адреса и проверки допустимости вводимых значений. \n В случае недопустимых значений полей выбрасываются исключения. \n Написать программу, демонстрирующую все разработанные элементы класса. \n");
                try
                {
                    Main organization = new Main();
                    Console.WriteLine(" Введите название вашей организации:");
                    organization.Nazvanie = Vvod1();
                    Console.WriteLine(" Укажите почтовый индекс вашей организации: ");
                    organization.Index = Vvod();
                    Console.WriteLine(" Укажите город, в котором находится ваша организация ");
                    organization.Ulitsa = Vvod1();
                    Console.WriteLine(" Укажите на какой улице находится ваша организация:");
                    organization.Ulitsa = Vvod1();
                    Console.WriteLine(" Укажите номер дома: ");
                    organization.Nomer = Vvod();
                    Console.WriteLine(" \n Ваша организация: \n");
                    Console.WriteLine(" Название: " + organization.Nazvanie);
                    Console.WriteLine(" Почтовый индекс: " + organization.Index);
                    Console.WriteLine(" Город: " + organization.Gorod);
                    Console.WriteLine(" Улица, дом: " + organization.Ulitsa + ", " + organization.Nomer);
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно задано значение!");
                }
                Console.ReadKey();
            }
        }
    }
}