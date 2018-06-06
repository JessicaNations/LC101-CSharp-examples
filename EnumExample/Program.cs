using System;

namespace EnumExample
{
    public enum Color{
        Blue,
        Yellow,
        Orange,
        Purple,
        Unknown
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose: Blue or Yellow");
            string input = Console.ReadLine(); 
            Color color =(Color)Enum.Parse(typeof(Color), input);
            Color colorPlusRed = GetColorPlusRed(color);
            Console.WriteLine(colorPlusRed.ToString());
            Console.ReadLine();
        }


        public static Color GetColorPlusRed(Color color)
        {
            if (color == Color.Blue)
                return Color.Purple;
            else if (color == Color.Yellow)
                return Color.Orange;
            else
                return Color.Unknown;
        }

    }
}
