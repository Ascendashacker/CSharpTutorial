
using System;

namespace Sorting
{
    /// <summary>
    /// 功能描述(Description)：	直接插入排序
    /// 作者(Author)：			姚腾飞
    /// 日期(Create Date)：		2019/2/15 10:47:54
    /// </summary>
    public static class InsertSort
    {
        public static void Sort(int[] array)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("直接插入排序前的数组：");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int curPosition = 1;//无序集中的第一个元素所在的位置
            while (curPosition < array.Length)
            {
                int temp2 = array[curPosition];
                for (int i = 0; i < curPosition; i++)
                {
                    if (temp2 < array[i])  //将无序集中的第一个元素与有序集中的数据按顺序比较大小
                    {
                        for (int j = curPosition; j > i; j--)  //挪动元素
                        {
                            array[j] = array[j - 1];
                        }
                        array[i] = temp2;
                        break;
                    }
                }
                curPosition++;
            }
            Console.WriteLine("直接插入排序后的数组：");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("直接插入排序所花费的时间：" + (DateTime.Now - startTime));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
