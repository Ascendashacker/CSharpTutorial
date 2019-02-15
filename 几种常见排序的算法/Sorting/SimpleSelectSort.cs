
using System;

namespace Sorting
{
    /// <summary>
    /// 功能描述(Description)：	简单选择排序
    /// 作者(Author)：			姚腾飞
    /// 日期(Create Date)：		2019/2/15 10:25:28
    /// </summary>
    public static class SimpleSelectSort
    {
        public static void Sort(int [] array)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("简单选择排序前的数组：");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int temp = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            Console.WriteLine("简单选择排序后的数组：");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("简单选择排序所花费的时间：" + (DateTime.Now - startTime));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
