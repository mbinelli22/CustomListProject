using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> customList = new CustomList<int>();

            customList.Add(5);
            customList.Add(6);
            customList.Remove(5);
        }
    }
}
