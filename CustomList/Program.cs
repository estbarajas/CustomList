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
            CustomList<int> theListOne = new CustomList<int>() {1,2,3};
            CustomList<int> theListTwo = new CustomList<int>() {4,2,5};

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
