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
            CustomList<int> thelister = new CustomList<int>();
            thelister.Add(100);
            thelister.Add(200);
            thelister.Remove(300);
            thelister.PrintArray();
            Console.ReadLine();
        }
    }
}
