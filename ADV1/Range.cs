using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV1
{
    internal class Rangeofvalue<T> where T : IComparable<T>
    {

        private  T  Min { get; set; }
        private T Max { get; set; }

        public Rangeofvalue(T min, T max)
        {
            Min = min;
            Max = max;


            if (min.CompareTo(max) >= 0) 
                Console.WriteLine("Value cannot be greater than max");
               
        }


       

        public bool IsInRange(T value)
        { 
            return value.CompareTo(Min) >= 0 &&
                value.CompareTo(Max)<=0;
        
        
        
        
        }



        public T length()
        {
           dynamic min = Min;
           dynamic max = Max; 
            return max - min;

        
        
        
        
        }


    




    }
}
