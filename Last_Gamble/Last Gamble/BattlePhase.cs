using System;

namespace Last_Gamble
{
    public static class Battle
    {
        public static int PlayerRoll;
        public static int EnemyRoll;
        public static int PlayerPoints;
        public static int EnemyPoints;
        public static int PlayerWin;
        public static int EnemyWin;
        static Random rnd = new Random();

        public static void RollDice(string player, string enemy)
        {

            for (int j = 1; j < 11; j++)
            {
                Console.WriteLine("\nPress any key to roll the dice.\n");
                Console.ReadKey();
                PlayerRoll = rnd.Next(1, 7);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Round {j}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"{player} rolled a [{PlayerRoll}]");
                Console.WriteLine("------------------------------------------------");
                EnemyRoll = rnd.Next(1, 7);
                Console.WriteLine($"{enemy} rolled a [{EnemyRoll}]");
                Console.WriteLine("------------------------------------------------");

                if (PlayerRoll > EnemyRoll)
                {
                    PlayerPoints++;
                    Console.WriteLine($"{player} win this round ");
                }
                else if (PlayerRoll < EnemyRoll)
                {
                    EnemyPoints++;
                    Console.WriteLine($"{enemy} win this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Score \n{player} : {PlayerPoints}  \n{enemy} : {EnemyPoints}");
                Console.WriteLine("------------------------------------------------");
            }

            if (PlayerPoints > EnemyPoints)
            {
                PlayerWin++;
                Console.WriteLine($"{player} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
            }
            else if (PlayerPoints < EnemyPoints)
            {
                EnemyWin++;
                Console.WriteLine($"{enemy} win this match \n{enemy} Point : {EnemyWin}/3 \n{player} Point : {PlayerWin}/3");
            }
            else if (PlayerPoints == EnemyPoints)
            {
                PlayerWin = 0;
                EnemyWin = 0;
                Console.WriteLine("Draw !");
                Console.WriteLine($"{player} Point : {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
            }

            Console.WriteLine("\nPress any key to next stage\n");
        }

        public static void RandomNumber(string player, string enemy)
        {
            Console.WriteLine("Stage 2 : Random number");
            Console.WriteLine("Random the numbers 3 times and add them together.");
            Console.ReadKey();
            bool replay = true;

            while (replay)
            {
                int playerNumber1 = rnd.Next(1, 100);
                int playerNumber2 = rnd.Next(1, 100);
                int playerNumber3 = rnd.Next(1, 100);

                Console.WriteLine($"\n{player} Random number : {playerNumber1} + {playerNumber2} + {playerNumber3}");
                Console.ReadKey();

                int playerScore = playerNumber1 + playerNumber2 + playerNumber3;
                Console.WriteLine("Sum : {0}", playerScore);
                Console.ReadKey();

                int enemyNumber1 = rnd.Next(1, 100);
                int enemyNumber2 = rnd.Next(1, 100);
                int enemyNumber3 = rnd.Next(1, 100);
                Console.WriteLine($"{enemy} Random number : {enemyNumber1} + {enemyNumber2} + {enemyNumber3}");
                Console.ReadKey();

                int enemyScore = enemyNumber1 + enemyNumber2 + enemyNumber3;
                Console.WriteLine("Sum : {0}", enemyScore);
                replay = false;

                Console.ReadKey();
                if (playerScore > enemyScore)
                {
                    PlayerWin++;
                    Console.WriteLine($"{player} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
                }
                else if (playerScore < enemyScore)
                {
                    EnemyWin++;
                    Console.WriteLine($"{enemy} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
                }
                else
                {
                    Console.WriteLine("Draw !");
                }
            }
            Console.WriteLine("\nPress any key to next stage\n");
            Console.ReadKey();
        }

        public static void HeadTail(string player, string enemy)
        {

            int headtail = rnd.Next(1,2);
            Console.WriteLine("\nStage 3 : Head and Tail");
            Console.WriteLine("{0} has guess first (Input Head or Tail)", player);
            Console.Write("{0} Guess :", player);
            string guessing = Console.ReadLine();

            if (headtail == 1 && guessing == "Head")
            {
                PlayerWin++;
                Console.WriteLine("The coin flip Head !");
                Console.WriteLine($"{player} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
                
            }
            else if (headtail == 2 && guessing == "Tail")
            {
                PlayerWin++;
                Console.WriteLine("The coin flip Tail !");
                Console.WriteLine($"{player} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
            }
            else
            {
                EnemyPoints++;
                Console.WriteLine($"{enemy} win this match \n{player} Point: {PlayerWin}/3 \n{enemy} Point : {EnemyWin}/3");
            }
            Console.ReadKey();
        }

        public static void ResultPoint()
        {
            if (PlayerWin > EnemyWin)
            {
                Console.WriteLine("You win !!");
            }
            else if (EnemyWin > PlayerWin)
            {
                Console.WriteLine("You lose !!");
            }
            else
            {
                Console.WriteLine("Draw !!");
            }
        }
    }
}