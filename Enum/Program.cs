namespace EnumApplication
{
    class Color
    {
        public enum ColorEnum
        {
            Red,
            Green,
            Blue
        };
        static void Main(string[] args)
        {
            ColorEnum color = ColorEnum.Red;
            // 访问枚举对象
            Console.WriteLine(color); 
           
            // 访问枚举对象的值
            Console.WriteLine((int)color);

            // 访问枚举对象的名称
            Console.WriteLine(color.ToString());

            // 定义对象的值
            int val = 2;
            // 根据值访问枚举对象
            ColorEnum color2 = (ColorEnum)val;
            Console.WriteLine(color2);

            // 定义枚举对象的名称
            string name = "Green";
            // 根据名称访问枚举对象
            ColorEnum color3 = Enum.Parse<ColorEnum>(name);
            Console.WriteLine(color3); 

            // 定义枚举对象的名称
            string name2 = "Blue";
            // 根据名称访问枚举对象
            ColorEnum color4 = Enum.Parse<ColorEnum>(name2);
            Console.WriteLine(color4);

            string[] names = Enum.GetNames(typeof(ColorEnum));
            foreach (string s in names)
                Console.WriteLine(s);
        }
    }
}