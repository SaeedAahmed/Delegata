using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegata.Delegate
    
{
    public delegate bool compareFunDelegate(int a, int b);

 
    internal class SortingAlgorithms
    {
        private static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSOrtAsc(int[] arr , compareFunDelegate compareDelegate)
        {
            compareDelegate = default;
            if(arr is not null && compareDelegate is not null)
                for(int i = 0; i < arr.Length; i++)                
                    for (int j = 0;i< arr.Length - i - 1; j++)                    
                        if (compareDelegate.Invoke(arr[j], arr[j + 1]))
                            swap(ref arr[j] ,ref arr[j+1]);
        }

        //public static void BubbleSOrtDesc(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; i < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1])
        //                {
        //                    swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
    }

    class compareFunction
    {
        public static bool compareGrt(int x , int y) // sort asc
        {
            return x > y;
        }
        public static bool compareLess(int x, int y) //sort desc
        {
            return x < y;
        }
    }
}
