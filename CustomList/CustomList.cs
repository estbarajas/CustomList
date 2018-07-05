using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        
        public int Count;
        private T value;

        public CustomList(T value)
        {
            this.value = value;
        }
    }
}
