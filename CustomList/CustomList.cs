using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {// member variables - Has A
        // index [] - where each item is located
        // count - has how many items
        // capacity - how many items can fit in list

        public T[] customList;         
        public int count;
        public int capacity;

        public T this[int index]    // Indexer declaration  
        {
           get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return customList[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                customList[index] = value;
            }
        }

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
            T[] customList = new T[capacity];

            for (int i = 0; i < count; i++)
            {

            }
            
           
        }
        public void Remove(T item)
        {

        }

    }
}
