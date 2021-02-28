using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QueueArray<int> array = new QueueArray<int>();
                QueueList<int> list = new QueueList<int>();
                QueueArray<string> array1 = new QueueArray<string>();
                QueueList<string> list1 = new QueueList<string>();

                for (int i = 0; i < 10; i++)
                {
                    array.AddinQueue(i + 1);
                    list.AddinQueue(i - 10);
                }
                somefunction(array);
                somefunction(list);
                int temp = array.GetElemOut();
                Console.WriteLine(temp);
                somefunction(array);
                string[] t = { "Leonid", "primi laby", "plz" };
                string[] t1 = { "mne", "nushen", "examen", "plz" };
                array1.AddinQueue(t);
                list1.AddinQueue(t1);
                somefunction(array1);
                somefunction(list1);
                Console.WriteLine(array1.GetLenghts());
                Console.WriteLine("Dostal stroky - " + list1.GetElemOut());
                somefunction(list1);
                QueueArray<int> array2 = new QueueArray<int>();
                array2.AddinQueue(2);
                array2.AddinQueue(2);
                array2.GetElemOut();
                array2.GetElemOut();
                array2.GetElemOut();
                Console.WriteLine(array2.GetLenghts());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void somefunction<T>(IQueue<T> a)
        {
            a.Show();
        }
    }
}
