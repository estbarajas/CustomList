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

        public int capacity;
        public int Count;
        public int nextIndex;
        //public int removeItem;

        public CustomList()
        {
            capacity = 5;
            mainArray = new T[capacity];
            Count = 0;
            nextIndex = 0;
        }

        public void Add(T valueToAdd)
        {            
            if (Count >= capacity)
            {
                ResizeArrayCapacity();
            }
            mainArray[Count] = valueToAdd;
            Count++;
        }

        public bool Remove(T valueToRemove)
        {
            bool itemWasRemoved = false;
            T[]temporaryArray = new T[Count-1];
            for(int i = 0; i < Count; i++)
            {
                if(!itemWasRemoved)
                {
                    if(mainArray[i].Equals(valueToRemove))
                    {
                        itemWasRemoved = true;                       
                    }
                    else
                    {
                        temporaryArray[i] = mainArray[i];
                    }
                }
                else
                {
                    temporaryArray[i - 1] = mainArray[i];
                }               
            }
            mainArray = temporaryArray;
            Count--;
            return itemWasRemoved;
        }

        public void PrintArray()
        {
            foreach (T i in mainArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The count of the array is: " + Count + " elements.");
        }

        public void ResizeArrayCapacity()
        {
            capacity = capacity * 2;
            T[] tempArray = new T[capacity];
            CopyArray(Count - 1, tempArray, mainArray);
            mainArray = tempArray;
        }

        public void CopyArray(int count, T[] tempArray, T[] mainArray)
        {
            for (int i=0; i <= count; i++)
            {
                if (i <= count)
                {
                    tempArray[i] = mainArray[i];
                }
            }
        }
    }
}
