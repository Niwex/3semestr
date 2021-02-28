using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    interface IQueue<T>
    {
        void AddinQueue(T a);
        void AddinQueue(T[] a);
        T GetElemOut();
        int GetLenghts();
        void Show();
    }
}
