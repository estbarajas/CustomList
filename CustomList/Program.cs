using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> thelister = new CustomList<int>();
            //thelister.Add(100);
            //thelister.Add(200);
            //thelister.Remove(300);
            ////thelister.PrintArray();

            //foreach(int number in thelister)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadLine();

            CustomList<int> theListOne = new CustomList<int>() {1,2,3};
            CustomList<int> theListTwo = new CustomList<int>() {5,2,4};

            CustomList<int> ZipTwoLists = theListOne.Zip(theListTwo);
            string printZipTwoLists = ZipTwoLists.ToString();
            Console.WriteLine(printZipTwoLists);

            CustomList<int> AddTwoLists = theListOne + theListTwo;
            string printAddTwoLists = AddTwoLists.ToString();
            Console.WriteLine(printAddTwoLists);

            CustomList<int> RemoveFromTheTwoLists = theListOne - theListTwo;
            string prinRemoveFromTheTwoLists = RemoveFromTheTwoLists.ToString();
            Console.WriteLine(prinRemoveFromTheTwoLists);

            Console.ReadLine();
        }
    }
}
