
using System;

namespace Sorting
{
    /// <summary>
    /// 功能描述(Description)：	冒泡排序	
    /// 作者(Author)：			姚腾飞
    /// 日期(Create Date)：		2019/2/15 9:28:52
    /// </summary>
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            //排序前的数组
            DateTime startTime = DateTime.Now;
            Console.WriteLine("冒泡排序前的数组：");
            foreach (var item in array)
            {   
                Console.Write(item +" ");
            }
            Console.WriteLine();
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1 -i; j++)//每一次循环后最大值一定会移到最右边
                {
                    if (array[j] >array[j+1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            //排序后的数组
            Console.WriteLine("冒泡排序后的数组：");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("冒泡排序花费的时间："+ (DateTime.Now -startTime));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
