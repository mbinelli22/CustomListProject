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
        public int Count;
        int capacity;

        //constructor
        public CustomList()
        {
            this.capacity = 5;
            this.data = new T[capacity];
            this.Count = 0;

        }

        //member methods

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public void MyList()
        {
            data = new T[Count];
        }

        public void Add(T value)
        {
            bool isTrueOrFalse = IsCapacityGreaterThanCount();

            if (isTrueOrFalse)
            {
                T[] tempData = new T[capacity];

                for (int i = 0; i <= Count; i++)
                {
                    tempData[i] = data[i];
                }

                data = tempData;
            }
            data[Count] = value;

            Count++;                  

        }

        private bool IsCapacityGreaterThanCount()
        {
            if (Count > capacity)
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

        public bool Remove(T value)
        {
            for (int i = 0; i <= Count; i++)
            {
                if (data[i].Equals(value) )//array has value im looking for return true, have other values slide down
                {
                    

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }









}
}

