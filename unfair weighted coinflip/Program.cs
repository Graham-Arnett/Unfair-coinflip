using System.Runtime.InteropServices;

namespace unfair_weighted_coinflip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You pass by a bridge and a hideous troll stops you.");
            Console.WriteLine("\"Want to flip a coin that isn't actually fair? You'll be tails!\"");
            Random random = new Random();
            Console.WriteLine("How many times do you want to flip?");
            int coinflips = int.Parse(Console.ReadLine());


            for (int f = 0; f < coinflips; f++)
            { //i is standard for for loops because it stands for iteration, I am using f for flips
                {
                    int coin = random.Next(0, 10); //its wildly weighted against you

                    if (coin <= 8)
                    {
                        Console.WriteLine("He lets out an irritating cackle.");
                        Console.WriteLine("\"Heads, you lose!\"");
                    }
                    else
                    {
                        Console.WriteLine("He doesn't laugh.");
                        Console.WriteLine("\"Boo, how'd you manage that? I guess you win.\"");
                    }

                }

            }
        }
    }
}