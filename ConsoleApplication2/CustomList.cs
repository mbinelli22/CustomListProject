using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class CustomList<T>
    {
        //member variables

        T[] data;
        int count;
        int capacity;

        //constructor
        public CustomList()
        {
            this.capacity = 5;
            this.data = new T[capacity];
            this.count = 0;

        }

        //member methods

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public void Add(T value)
        {
            //Check to make sure that you have room in your array for the new item
            //If you dont have enough room, call another method (that you have to write) that creates a new array (temp) of double the size of the existing one
            //then transfer the data from the old array to the new array. 
            // set data = to the new array
            //If or once you have room, add the new item to the array
            bool isTrueOrFalse = IsCapacityGreaterThanCount();

            if (isTrueOrFalse)
            {
                T[] tempData = new T[capacity];

                for (int i = 0; i <= count; i++)
                {
                    tempData[i] = data[i];
                }

                data = tempData;
            }
            data[count] = value;

            count++;                  

        }

        private bool IsCapacityGreaterThanCount()
        {
            if (count > capacity)
            {
                ExpandArray();
                return true;
                
            }
            else
            {
                return false;
            }

        }


        public void ExpandArray()
        {
            capacity *= 2;            
        }

        //public void Remove()
        //{
        //    for ()
        //    {
        //        if ()//array has value im looking for return true, have other values slide down
        //        {

        //        }
        //        else
        //        {
        //            //return false
        //        }
        //    }
        //}









    }
}

