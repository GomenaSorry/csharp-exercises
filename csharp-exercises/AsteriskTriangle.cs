namespace csharp_exercises
{
    public partial class Program
    {
        public class AsteriskTriangle
        {
            public static void Write(int length)
            {
                for (int level = 1; level <= length; level++)
                {
                    Console.WriteLine(new string(' ', length - level) + new string('*', level));
                }
            }
        }
    }
}
