using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Смотрим тип int");
            int[] a = { 1, 2, 3, 4, 5, 6 };
            Queue<int> b = new Queue<int>();
            Console.WriteLine("Длина очереди - " + b.GetLenghts());
            b.AddinQueue(1);
            Console.WriteLine("Длина очереди - " + b.GetLenghts());
            b.AddinQueue(2);
            Console.WriteLine("Длина очереди - " + b.GetLenghts());
            b.AddinQueue(3);
            Console.WriteLine("Длина очереди - "+b.GetLenghts());
            b.Show();
            Console.WriteLine(b.GetElemOut());
            Console.WriteLine(b.GetElemOut());
            Console.WriteLine(b.GetElemOut());
            Console.WriteLine(b.GetElemOut());


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Смотрим тип string");


            string[] str = {"string" , "string","string"};
            Queue<string> c = new Queue<string>();
            Console.WriteLine("Длина очереди - " + c.GetLenghts());
            c.AddinQueue("12sad");
            Console.WriteLine("Длина очереди - " + c.GetLenghts());
            c.AddinQueue("321assd");
            Console.WriteLine("Длина очереди - " + c.GetLenghts());
            c.AddinQueue("dsdasdfsa");
            Console.WriteLine("Длина очереди - "+ c.GetLenghts());
            c.Show();
            Console.WriteLine(c.GetElemOut());
            Console.WriteLine(c.GetElemOut());
            Console.WriteLine(c.GetElemOut());
            Console.WriteLine(c.GetElemOut());
            c.AddinQueue(str);
            c.Show();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Смотрим тип double");


            Queue<double> d = new Queue<double>();
            Console.WriteLine("Длина очереди - " + d.GetLenghts());
            d.AddinQueue(1.312);
            Console.WriteLine("Длина очереди - " + d.GetLenghts());
            d.AddinQueue(2.3214);
            Console.WriteLine("Длина очереди - " + d.GetLenghts());
            d.AddinQueue(3.43242);
            Console.WriteLine("Длина очереди - "+ d.GetLenghts());
            d.Show();
            Console.WriteLine(d.GetElemOut());
            Console.WriteLine(d.GetElemOut());
            Console.WriteLine(d.GetElemOut());
            Console.WriteLine(d.GetElemOut());
            
            
        }
    }
}
