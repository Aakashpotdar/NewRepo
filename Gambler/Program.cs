using System;

namespace Gambler
{
    class Program
    {
        static int cash = 100;
        static void Main(string[] args)
        {
            Uc1_StackEveryDay ObjUc1 = new Uc1_StackEveryDay();
            int remainingAmount=ObjUc1.PlayGame(cash);
            Console.WriteLine(remainingAmount);
        }
    }
}
