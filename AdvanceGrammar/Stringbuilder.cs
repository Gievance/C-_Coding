
using System.Text;

namespace AdvanceGrammar
{
    class Stringbuilder
    {
        /// <summary>
        /// 学习 StringBuilder
        /// 1. 创建StringBuilder
        /// 2. Append(string)
        /// 3. Insert(index,string)
        /// 4. Remove(startindex,length)
        /// 5. Replace(old,new)
        /// 6. ToString()
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   //1 具有初始值的 创建StringBuilder
            StringBuilder sb = new StringBuilder("www.baidu.com");
            //
         
            sb.Append("/index.html"); // Append 追加字符串
            sb.Insert(0, "http://");// 从 (指定位置) 插入 (指定字符串)

            Console.WriteLine(sb.ToString());

            sb.Remove(0, 4); // 从 (指定位置) 移除 (指定长度字符)
            Console.WriteLine(sb.ToString());

            sb.Replace("://", "");
            Console.WriteLine(sb.ToString());
            //2 具有指定长度的 创建StringBuilder
            StringBuilder sb2 = new StringBuilder(20);
            //3 具有初始值和长度的 创建StringBuilder
            StringBuilder sb3 = new StringBuilder("www.baidu.com", 100);





        }

    }
}
