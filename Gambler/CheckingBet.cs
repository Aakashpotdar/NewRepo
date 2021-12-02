using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    public class CheckingBet
    {
        public void checkGame()
        {
            Uc1_StackEveryDay ObjAmount = new Uc1_StackEveryDay();

            Random random = new Random();
            int GameWinLoos = random.Next(0, 2);

            if (GameWinLoos == 1)
            {
                Uc1_StackEveryDay.CashPerDay++;
                Console.WriteLine("You won the Game");
            }
            else
            {
                Uc1_StackEveryDay.CashPerDay--;
                Console.WriteLine("You loss the Game");
            }
        }
    }
}
