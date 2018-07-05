using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{

    public class CustomList<T>
    {
        private T[] mainArray = new T[100];

        public T this[int i]
        {
            get { return mainArray[i]; }
            set { mainArray[i] = value; }
        }

        public int Count;
        public int nextIndex;

        public CustomList()
        {
            Count = 0;
            nextIndex = 0;
        }

        public void Add(T passedValue)
        {            
            if (nextIndex == 0)
            {
                mainArray[0] = passedValue;
                nextIndex++;
                Count++;
            }
            else if (nextIndex >= 1)
            {
                mainArray[nextIndex++] = passedValue;
                Count++;
            }
        }

        public void Remove(T passedValue)
        {

        }

        public void PrintArray()
        {
            foreach (T i in mainArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
