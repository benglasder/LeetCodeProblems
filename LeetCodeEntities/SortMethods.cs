using System.CodeDom.Compiler;
using System.Threading;

namespace LeetCodeEntities
{
    public class SortMethods
    {
        public static int[] BubbleSort(int[] arr)
        {
            var flag = true;
            int temp = 0;
            for (int i = 1; i <= arr.Length - 1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            //Thread.Sleep(200);
            return arr;
        }
    }
}