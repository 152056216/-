using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//输入两个操作数
//捕获异常
//选择操作
//除法捕获异常
//输出结果
namespace ConsoleApplication8
{
    class Program
    {
        private static float num1;
        private static float num2;
        private static int num3;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("请输入两个数");
                try
                {

                    num1 = float.Parse(Console.ReadLine());
                    num2 = float.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }


            Console.WriteLine("请选择要进行的算法：\n1.加法\n2.减法\n3.乘法\n4.除法");
            num3 = int.Parse(Console.ReadLine());
            switch (num3)
            {
                case 1:
                    Console.WriteLine(add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine(minus(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(ride(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(eliminate(num1, num2));
                    break;

            }


        }
        private static void input()
        {


        }
        private static float add(float num1, float num2)
        {

            return num1 + num2;

        }
        private static float minus(float num1, float num2)
        {

            return num1 - num2;

        }
        private static float ride(float num1, float num2)
        {

            return num1 * num2;

        }
        private static float eliminate(float num1, float num2)
        {
            float i = 99999;
            try
            {

                i = num1 / num2;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }


            return i;

        }
    }

}

