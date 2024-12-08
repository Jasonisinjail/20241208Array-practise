using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHomeWork01();
            MyHomeWork02();
            Console.ReadLine();
        }
        static void Fun01(double x,double y)//算平均值
        { 
            double avg = x / y;
            Console.WriteLine("該陣列平均值:{0:g}",avg);
        }
        static void MyHomeWork01()
        {
            int[] number = new int[10];
            float[] number2 = new float[8];
            double[] number3 = new double[4];
            string[] number4 = new string[5];
            int i = 0;
            Console.WriteLine($"請輸入{number.Length}個整數");
            while (i < number.Length)
            {
                Console.WriteLine($"請輸入第{i+1}個整數");
                number[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("整數陣列的資料:");
            foreach (var num in number)
            {
                Console.WriteLine($"{num}");
            }
            Fun01(number.Sum(), number.Length);
            i = 0;
            Console.WriteLine($"請輸入{number2.Length}個浮點數");
            while (i < number2.Length)
            {
                Console.WriteLine($"請輸入第{i + 1}個浮點數");
                number2[i] = float.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("浮點數陣列的資料:");
            foreach (var num in number2)
            {
                Console.WriteLine($"{num}");
            }
            Fun01(number2.Sum(), number2.Length);
            i = 0;
            while (i < number3.Length)
            {
                Console.WriteLine($"請輸入第{i + 1}個倍精確度數");
                number3[i] = double.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("倍精確度數陣列的資料:");
            foreach (var num in number3)
            {
                Console.WriteLine($"{num}");
            }
            Fun01(number3.Sum(), number3.Length);
            i = 0;
            Console.WriteLine($"請輸入{number4.Length}個字串");
            while (i < number4.Length)
            {
                Console.WriteLine($"請輸入第{i + 1}個字串");
                number4[i] = Console.ReadLine();
                i++;
            }
            Console.WriteLine("字串陣列的資料:");
            foreach (var num in number4)
            {
                Console.WriteLine($"{num}");
            }

        }
        static void MyHomeWork02()
        {
            int[] number = { 1, 2, 3, 4, 5 };
            float[] number2 = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            double[] number3 = { 1.22, 2.33, 3.44, 4.55, 5.66 };
            string[] number4 = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };
            int n = 0;
            Console.WriteLine("整數陣列的資料:");
            while (n < 5)
            {
                Console.WriteLine(number[n]);
                n = n + 1;
            }
            Fun01(number.Sum(), number.Length);
            n = 0;
            Console.WriteLine("浮點數陣列的資料:");
            while (n < 5)
            {
                Console.WriteLine(number2[n]);
                n = n + 1;
            }
            Fun01(number2.Sum(), number2.Length);
            n = 0;
            Console.WriteLine("倍精確度數陣列的資料:");
            while (n < 5)
            {
                Console.WriteLine(number3[n]);
                n = n + 1;
            }
            Fun01(number3.Sum(), number3.Length);
            n = 0;
            Console.WriteLine("字串陣列的資料:");
            while (n < 5)
            {
                Console.WriteLine(number4[n]);
                n = n + 1;
            }
            n = 0;

        }
    }
}
