//namespace _6_практика
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int n = int.Parse(Console.ReadLine());
//            if (n <= 0)
//            {
//                Console.WriteLine("Я не знаю отрицательных чисел :/");
//            }
//            int[] a = new int[n];
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = rnd.Next(-1, 11);
//                Console.Write(a[i] + " ");
//            }
//            bool bbq = false; 
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] < 0)
//                {
//                    bbq = true;
//                }
//            }
//            Console.WriteLine(bbq);
//        }
//    }
//}
