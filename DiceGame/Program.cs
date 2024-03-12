using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints=0;
            int enemyPoints=0;


            Random random = new Random();
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a random number" + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);


                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("enemy AI rolled a "+ enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins the game");
                }
                else if(enemyRandomNum > enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("enemy wins the game");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The score is now - player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
                
            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(enemyPoints > playerPoints) 
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("Its a Draw");
            }

            Console.ReadKey();

            
        }
    }
}
