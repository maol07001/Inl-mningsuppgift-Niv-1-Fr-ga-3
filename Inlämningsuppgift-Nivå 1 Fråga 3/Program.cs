using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; // Variabel för summan

            Console.WriteLine("Skriv in 5 heltal:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Tal {i + 1}: ");
                int nummer = int.Parse(Console.ReadLine());
                sum += nummer; // sum = sum + nummer
            }
            Console.WriteLine("Summan av de fem talen är:"+sum);
        }
    }
}
