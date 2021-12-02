using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    public class CheckingBet
    {
        static int CashPerDay = 100;
        static int BetAmount = 1;
             
                
    
    public void checkGame()
        {
            CheckingBet obj = new CheckingBet();
            Random random = new Random();
            int GameWinLoos = random.Next(0, 2);

            if (GameWinLoos == 1)
            {
                CashPerDay= CashPerDay+BetAmount;
                Console.WriteLine("You won the Game");
            }
            else
            {
                CashPerDay = CashPerDay + BetAmount;
                Console.WriteLine("You loss the Game");
            }
        }
    }
}
