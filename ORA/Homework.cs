using System;


namespace ORA
{
    internal class Homework
    {
        // 输入10个数字
        // 定义average 方法，输出10个数的平均值

        public static double Average(List<int> nums)
        {
            return nums.Average();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入10个数字(请用逗号分隔)：");
            string[]? input = Console.ReadLine().Split(',') ?? null;
            List<int> inputs = new List<int>();
            while (true)
            {
                if (input != null && input.Length == 10)
                {
                    foreach (string s in input)
                    {
                        int cur_num = int.Parse(s);
                        inputs.Add(cur_num);
                    }
                    Average(inputs);
                }
                else
w    }
ww