using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{

    public class CustomList<T>
    {
        private T[] arr = new T[100];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public int Count;

        public CustomList()
        {
 
        }

        public void Add(T passedValue)
        {
            arr[0] = passedValue;

            foreach (T i in arr)
            {
                System.Console.Write("{0} ", i);
            }
        }
    }
}
