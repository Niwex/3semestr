using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class QueueArray<T> : IQueue<T>
    {
        T[] array = new T[0];
        public void AddinQueue(T a)
        {
            
            int i;
            if(array.Length!=0)
                {
                T[] temp = new T[array.Length + 1];
                for (i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                temp[i] = a;
                array = temp;
            } 
            else
            {
                
                array = new T[1];
                array[0] = a;
            }
        }
        public void AddinQueue(T[] a)
        {
            T[] temp = new T[array.Length + a.Length];
            
            if (array.Length != 0)
            {
                int i;
                for (i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                for (int j = 0; j < a.Length; j++)
                {
                    temp[i  + j] = a[j];
                }
                array = temp;

            }
            else
            {
                array = new T[a.Length];
                for(int i = 0; i<a.Length; i++ )
                {
                    array[i] = a[i];
                }
            }
        }
        public T GetElemOut()
        {
            if(array.Length == 0)
            {
                throw new Exception("Array empty");
            }
            T[] temp = new T[array.Length - 1];
            T returnValue = array[0];
            for(int i = 1; i <array.Length; i++)
            {
                temp[i-1] = array[i];
            }
            array = temp;
            return returnValue;
        }
        public int GetLenghts()
        {
            return array.Length;
        }
        public void Show()
        {
            foreach(T x in array)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
        }
    }
}
