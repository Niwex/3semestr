using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[1];
            bool done = false;
            while (!done)
            {
                switch (Menu())
                {
                    case 1: arrays = makeArrays(); break;
                    case 2: showArray(arrays); break;
                    case 3: sceplenieArray(arrays); break;
                    case 4: sliyanie(arrays); break;
                    case 5: showElem(arrays); break;
                    case 6:
                        Console.WriteLine("End");
                        done = true; break;
                }
            }
        }



        static int Menu()
        {
            Console.WriteLine("Cоздать масивы - 1. Показать масив - 2. Поэлементно сцепить масивы - 3");
            Console.WriteLine("Слить два масива в один - 4. Показать конкретный элемент масива и сам масив - 5");
            Console.WriteLine("Выход - 6");
            bool right = false;
            int flag = 0;
            while (!right)
            {
                flag = Int32.Parse(Console.ReadLine());
                if (flag > 0 && flag <= 6)
                {
                    right = true;
                }
                else
                {
                    Console.WriteLine("Введите от 1 до 6");
                }
            }
            Console.WriteLine();
            return flag;
        }
        static Array[] makeArrays()
        {
            Array[] arrays;
            Console.WriteLine("Сколько масивов создать?");
            int kolmas = Int32.Parse(Console.ReadLine());
            arrays = new Array[kolmas];
            for (int i = 0; i < kolmas; i++)
            {
                Console.WriteLine("Введите кол-во символов в " + i + " масиве");
                int n = Int32.Parse(Console.ReadLine());
                string str = "";
                bool right = false;
                while (!right)
                {
                    Console.WriteLine("Введите строку");
                    str = Console.ReadLine();
                    if (str.Length != n)
                    {
                        Console.WriteLine("Длина строки которую вы указали не совпадает со строкой которую вы ввели");

                    }
                    else right = true;
                }
                arrays[i] = new Array(str, n);
            }
            Console.WriteLine();
            return arrays;

        }

        static void showArray(Array[] arrays)
        {
            int n = arrays.Length;
            int i = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Введите номер массива для просмотра");
                i = Int32.Parse(Console.ReadLine());
                if (i >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            Console.WriteLine(arrays[i].getString());
            Console.WriteLine();
        }

        static void sceplenieArray(Array[] arrays)
        {
            int i = 0, j = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Выберите первый масив для сцепления");
                i = Int32.Parse(Console.ReadLine());
                if (i >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            done = false;
            while (!done)
            {
                Console.WriteLine("Выберите второй масив для сцепления");
                j = Int32.Parse(Console.ReadLine());
                if (j >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            string newArray = IArray<Array>.sceplenie(arrays[i], arrays[j]);
            Console.WriteLine("Получен масив");
            Console.WriteLine(newArray);
            Console.WriteLine();
        }

        static void sliyanie(Array[] arrays)
        {
            int i = 0, j = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Выберите первый масив для Слияния");
                i = Int32.Parse(Console.ReadLine());
                if (i >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            done = false;
            while (!done)
            {
                Console.WriteLine("Выберите второй масив для Слияния");
                j = Int32.Parse(Console.ReadLine());
                if (j >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            arrays[i].sliyanie(arrays[j]);
            Console.WriteLine("Масив " + i + " теперь выглядит так: " + arrays[i].getString());
            Console.WriteLine();
        }

        static void showElem(Array[] arrays)
        {
            int i = 0, j = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Выберите масив для просмотра");
                i = Int32.Parse(Console.ReadLine());
                if (i >= arrays.Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays.Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays.Length - 1));
                }
                else done = true;
            }
            done = false;
            while (!done)
            {
                Console.WriteLine("Выберите элемент для просмотра");
                j = Int32.Parse(Console.ReadLine());
                if (j >= arrays[i].getString().Length)
                {
                    Console.WriteLine("В масиве всего " + (arrays[i].getString().Length) + " элементов. Введите число начиная с 0 и заканчивая " + (arrays[i].getString().Length - 1));
                }
                else done = true;
            }
            arrays[i].showElemString(j);
            Console.WriteLine();
        }
    }
}
