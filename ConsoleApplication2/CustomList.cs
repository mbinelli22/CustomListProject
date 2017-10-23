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

        T value;
        int[] array;
        

        //constructor
        public CustomList(T value)
        {
            this.value = value;
            int[] array = new int[5];

                
        }

        //member methods
        
        public void Add<T>(T value, int[] array)
        {
            int[] array = new int[5];
            for(int runs = 0; runs < 5; runs++)
            {
                array[runs] = value;
            }

        }


    }
}
