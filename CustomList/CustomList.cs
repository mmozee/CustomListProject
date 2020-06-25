using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {// member variables - Has A
        // index [] - where each item is located
        // count - has how many items
        // capacity - how many items can fit in list

        T[] items;         
        private int count;
        private int capacity;
        //CustomList<T> listOne;
        //CustomList<T> listTwo;
        public int Count 
        { get 
           
            { 
                return count;
            } 
        
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public T this[int index]    // Indexer declaration  
        {
           get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
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
            if(Count==Capacity)
            {
                T[] tempArray = new T[capacity *= 2];

                for (int i = 0; i < Count; i++)
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
        
        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listTwo.Count; i++)
            {
                listOne.Remove(listTwo[i]);
            }

            return listOne;            
        }
        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> result = new CustomList<T>();
            int counter;
            counter = list.count;
            
            if (count > list.count)
            {
                counter = count;
            }
            
           // items 2,4,6,8       ?? list 1,3
            for (int i = 0; i < counter; i++)
            {
                if (i < count)
                {
                result.Add(items[i]);

                }
                if (i < list.count)
                {
                result.Add(list[i]);

                }
            }
           
           return result;// 2,1,4,3,6,5,
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];
            }
        }







    }
}
