using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            List<int> list = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(random.Next(0, 1000));
            }

            //https://www.cnblogs.com/chengxiao/p/6103002.html 三种排序算法图解

            //冒泡排序
            BubbleSort.Sort(list.ToArray());
            //简单选择排序
            SimpleSelectSort.Sort(list.ToArray());
            //直接插入排序
            InsertSort.Sort(list.ToArray());
        }
    }
}
