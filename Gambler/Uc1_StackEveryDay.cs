using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Uc1_StackEveryDay
    {

        public int PlayGame(int amount)
        {
            int remainingAmount = 0;
            int numberGame = 10;

            for(int i = 1; i < numberGame; i++)
            {
                remainingAmount = remainingAmount - amount;
            }
            

            return remainingAmount;
        }


    }
}
