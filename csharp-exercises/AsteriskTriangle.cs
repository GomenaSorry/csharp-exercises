namespace csharp_exercises
{
    public partial class Program
    {
        public class AsteriskTriangle       
        {
            public static void Write(int length)
            {
                int level = 0;
                while (level < length)
                {
                    level++;
                    for (int i = 0; i < (length - level); i++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < level; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
