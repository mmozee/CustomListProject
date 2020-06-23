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

            //OurCustomList
            //ourCustomList.Add(6);0
            //ourCustomList.Add(8);1
            //ourCustomList.Add(12);2
            //ourCustomList.Add(32);3
            //ourCustomList.Add(7);4
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
            



            //it will take the item
            
            //an array will be created
            //increase the counter
            //give it an index
            
           

            //T[] temporaryList;                                      
            ////if (count == capacity)                                   //if capacity is reached
            //{
            //    //capacity = capacity * 2;                             //increase capacity
            //    //temporaryList = new T[capacity];                     

            //    for (int i = 2; i < count; i++)                      //put it into the CustomList
            //    {
            //        CustomList] = customList[i];
            //    }
            //}




        }
        public void Remove(T item)
        {

        }

    }
}
