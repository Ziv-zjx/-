using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            
            GetBoxing();
            GetGeneric();
            //Thread t1 = new Thread(GetGeneric);
            //t1.Start();
            //Thread t = new Thread(GetBoxing);
            //t.Start();
            Read();
           
        }
        /// <summary>
        /// 装箱、拆箱操作
        /// </summary>
        public static void GetBoxing()
        {
            var startTime = DateTime.Now;
            WriteLine(startTime.ToString("HH:mm:ss fffffff"));//精确到100纳秒，最多精确到7位小数，不到7位的自动截断，单位是100纳秒(毫微妙)，这与Ticks精确度一样
            ArrayList arrayList = new ArrayList();
            for(int i=1;i<10000000 ;i++)//692986
            {
                arrayList.Add(i);
            }
            var endTime = DateTime.Now;
            WriteLine(endTime.ToString("HH:mm:ss fffffff"));
            WriteLine(string.Format("装箱所用的时间：{0}", endTime.Ticks - startTime.Ticks));
            WriteLine(string.Format("装箱所用的时间：{0}",endTime-startTime));

        }

        /// <summary>
        /// 使用泛型集合
        /// </summary>
        public static void GetGeneric()
        {
            var startTime = DateTime.Now;
            WriteLine(startTime.ToString("HH:mm:ss fffffff"));//精确到100纳秒，最多精确到7位小数，不到7位的自动截断，单位是100纳秒(毫微妙)，这与Ticks精确度一样
            List<int> list = new List<int>();
            for (int i = 1; i < 10000000; i++)//692986
            {
                 list.Add(i);
            }
            var endTime = DateTime.Now;
            WriteLine(endTime.ToString("HH:mm:ss fffffff"));
            WriteLine(string.Format("使用泛型所用的时间：{0}", endTime.Ticks - startTime.Ticks));
            WriteLine(string.Format("使用泛型所用的时间：{0}", endTime - startTime));
        }
    }
}
