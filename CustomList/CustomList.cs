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

        public T[] items;         
        public int count;
        public int capacity;

        public T this[int index]    // Indexer declaration  
        {
           get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                items[index] = value;
            }
        }

        // constructor - Spawner

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        // member methods - Can Do

        public void Add(T item)
        {
            if(count==capacity)
            {
                T[] tempArray = new T[capacity *= 2];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];

                }

                items = tempArray;
               
            }
          
            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            bool itemInTheList = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    itemInTheList = true;
                    count--;
                    for (int j = i; j < count; j++)
                    {
                        items[j] = items[j + 1];
                    }

                    break;
                } 
             }
            return itemInTheList;
        }
                        
        public override string ToString()
        {
            string convertedString = "";
            for (int i = 0; i < count; i++)
            {
                convertedString += items[i];
            }

            return convertedString;
        }
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {   
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < listOne.count; i++)
            {
                result.Add(listOne[i]);
                                    
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                result.Add(listTwo[i]);
            }

            return result;
        }
            ////Overload + operator to add two list objects
            //listOne = 6 + 8 + 12 + 32;
            //listTwo =





    }
}
