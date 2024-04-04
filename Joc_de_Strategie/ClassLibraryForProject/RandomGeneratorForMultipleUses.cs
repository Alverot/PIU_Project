using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForProject
{
    public class RandomGeneratorForMultipleUses
    {
        public static int[] RandomArrayGenerator(int size)
        {

            
            int[] randomArray = new int[size];
            Random random = new Random();
            for(int i = 0; i < size;i++)
            {
                int rnunber = random.Next(1,5);
                randomArray[i] = rnunber;
            }
            return randomArray;
        }
    }
}
