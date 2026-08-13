using System;
using System.Collections.Generic;
using System.Text;

namespace ORA
{
    internal class StaticClass
    {
        private static bool flag;
        private static StaticClass? instance = null;

        private StaticClass() { }
        static StaticClass() {
            flag = true;
            Console.WriteLine("StaticClass constructor called");
        }

        public static StaticClass GetInstance()
        {
            return instance ?? new StaticClass();
        }
    }
}
