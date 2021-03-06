﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{

    public class CustomList<T> : IEnumerable<T>
    
    {
        private T[] mainArray = new T[100];

        public T this[int i]
        {
            get { return mainArray[i]; }
            set { mainArray[i] = value; }
        }

        public int capacity;
        public int count;
        public int Count
        {
            get { return count;}
        }

        public CustomList()
        {
            capacity = 5;
            mainArray = new T[capacity];
            count = 0;
        }

        public void Add(T valueToAdd)
        {            
            if (Count >= capacity)
            {
                ResizeArrayCapacity();
            }
            mainArray[Count] = valueToAdd;
            count++;
        }

        public bool Remove(T valueToRemove)
        {
            bool itemWasRemoved = false;
            T[] temporaryArray = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                if (!itemWasRemoved)
                {
                    if (mainArray[i].Equals(valueToRemove))
                    {
                        itemWasRemoved = true;        
                       // Console.WriteLine("index value equals passedvalue");
                    }
                    else
                    {
                        temporaryArray[i] = mainArray[i];
                    }
                }
                else
                {
                    temporaryArray[i-1] = mainArray[i];
                }
            }
            if (itemWasRemoved == true)
            {
                count--;
            }
            mainArray = temporaryArray;
            return itemWasRemoved;
        }
        /*
        public void PrintArray()
        {
            foreach (T i in mainArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The count of the array is: " + Count + " elements.");
        }
        */
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

        public override string ToString()
        {
            string arrayValue = "";
            for (int i = 0; i < Count; i++)
            {
                arrayValue += mainArray[i] + " ";
            }
            return arrayValue;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return mainArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public CustomList<T> Zip(CustomList<T> passedList)
        {
            CustomList<T> listZip = new CustomList<T>();
            if (Count == passedList.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    listZip.Add(mainArray[i]);
                    listZip.Add(passedList[i]);
                }
                return listZip;
            }
            else if (Count > passedList.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    listZip.Add(mainArray[i]);
                    if (passedList.Count > i)
                    {
                        listZip.Add(passedList[i]);
                    }
                }
                return listZip;
            }
            return listZip;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultList = new CustomList<T>();
            foreach (T t in listOne)
            {
                resultList.Add(t);
            }
            foreach (T t in listTwo)
            {
                resultList.Add(t);
            }
            return resultList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            if (listOne != null && listTwo != null)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    listOne.Remove(listTwo.mainArray[i]);
                }
            }
            return listOne;
        }
    }
}
