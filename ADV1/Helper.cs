using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV1
{
    public static class Helper<T> where T :struct, IComparable<T>
    {


        public static void Swap(ref T x , ref T y)
        {
           

            T z;

            z = x;
            x = y;
            y = z;
            





        }




        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            { 
            
                for (int i = 0; i < array.Length; i++)            
                {


            
                    for (int j = 0; j < array.Length - i - 1; j++)            
                    {
            
                        if (array[j].CompareTo(array[j + 1])==1)            
                            Swap(ref array[j], ref array[j + 1]);
                                                                                  
                    }
                                                                                                                         
                }



            
            
            
            
            }
        
        
        
        
        }















    }
}
