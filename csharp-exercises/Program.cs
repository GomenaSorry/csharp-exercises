namespace csharp_exercises
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of the triangle:");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            AsteriskTriangle.Write(length);
        }
    }
}
