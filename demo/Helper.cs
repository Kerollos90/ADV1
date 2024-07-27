using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public static class Helper<T> where T : struct , IComparable<T>
    {

        public static int SearchArray(T[] array, T value)
        {
            if (array is not null)
                for ( int i = 0; i < array.Length ; i++)
                {
                    if (array[i].CompareTo(value)==0)
                        return i;


                }return -1;
        
        

        
        
        
            
        }

        





    }
}
