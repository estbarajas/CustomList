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
            CustomList<int> theListTwo = new CustomList<int>() {4,5,6};
            CustomList<int> theResult = theListOne + theListTwo;
            CustomList<int> theResult2 = theListOne - theListTwo;
            CustomList<int> theResult3 = theResult3.Zipper(theListOne,theListTwo));

            theListOne.ToString();

            //foreach(int number in theResult)
            //{
            //    Console.WriteLine(number);
            //}
            

            string printy = theResult.ToString();
            string printy2 = theResult2.ToString();
            Console.WriteLine(printy);
            Console.WriteLine(printy2);
            Console.ReadLine();
        }
    }
}
