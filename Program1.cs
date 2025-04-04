namespace задание3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random rna = new Random();
            Console.WriteLine(rna.Next());
            Console.WriteLine(rna.Next(5));
            Console.WriteLine(rna.Next(-5, 5));
            Console.WriteLine(rna.Next(a + b));
           

        }
    }
}
