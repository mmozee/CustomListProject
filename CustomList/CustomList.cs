using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] customList; 
        // member variables - Has A
        // index [] - where each item is located
        // count - has how many items
        // capacity - how many items can fit in list
        public int count;
        public int capacity;

        // constructor - Spawner

        public CustomList()
        {
            capacity = 4; 
            customList = new T[capacity];
            count = 0;
        }

        // member methods - Can Do

        public void Add(T item)
        {

        }
        public void Remove(T item)
        {

        }

    }
}
