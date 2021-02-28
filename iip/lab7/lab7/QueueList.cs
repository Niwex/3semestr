using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class QueueList<T> : IQueue<T>
    {
        List<T> list = new List<T>();
        public void AddinQueue(T a)
        {
            list.Add(a);
        }
        public void AddinQueue(T[] a)
        {
            list.AddRange(a);
        }
        public T GetElemOut()
        {

            List<T> temp = this.list;
            T returnValue = default(T);
            try
            {
                returnValue = temp[0];
                this.list.RemoveAt(0);

                return returnValue;
            }
            catch (Exception e)
            {
                Console.WriteLine("Что то не так");
                Console.WriteLine(e.Message);
                Console.WriteLine("Будет возвращен ноль");
                return returnValue;
            }
        }
        public int GetLenghts()
        {
            return list.Count;
        }
        public void Show()
        {
            foreach (T x in list)
            {
                Console.Write(x + ", ");

            }
            Console.WriteLine();
        }
    }
}
