using System;

namespace Last_Gamble
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Last Gamble");
            
            Battle.RollDice("Rose","Alan");
            Battle.RandomNumber("Rose","Aster");
            Battle.HeadTail("Rose","Daisy");
            Battle.ResultPoint();
        }
    }
}