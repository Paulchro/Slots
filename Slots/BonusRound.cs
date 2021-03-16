using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slots
{
    class BonusRound
    {
        public static void Bonus(double bet, double deposit, int spins)
        {
            var table = new List<string>() { "Wild", "Star", "Bell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            spins += 10;
            double bonus = 0;
            for (int y = 1; y < 10 + 1; y++)
            {
                List<string> one, two, three, four, five;
                List<string[]> reels;
                MainMenu.Spins(table, y, out one, out two, out three, out four, out five, out reels, spins);
                string what = "";
                double result = 0;
                Lines.One(bet, one, reels, ref what, ref result);

                Lines.Two(bet, two, reels, ref what, ref result);

                Lines.Three(bet, three, reels, ref what, ref result);

                Lines.Four(bet, four, reels, ref what, ref result);

                Lines.Five(bet, five, reels, ref what, ref result);
                bonus += result * 3;
                if (result > 0)
                {
                    deposit = deposit + (result * 3);
                    Console.WriteLine($"You won {result * 3}! You now have {deposit}");
                }

                else
                {

                    Console.WriteLine($"Nothing, balance: {deposit} ");
                    if (deposit <= 0)
                    {
                        Console.WriteLine("Not enough money");
                        break;
                    }
                }
                
            }
            spins -= 11;
            Console.WriteLine("Bonus round Ended");
            Console.WriteLine($"Bonus win: {bonus}");
            Console.WriteLine();

            Console.WriteLine("Θες να συνεχισεις? Y/N");
            PlayAgain(bet, deposit, spins, table);

        }

        private static void PlayAgain(double bet, double deposit, int spins, List<string> table)
        {
            string g = Console.ReadLine().ToUpper();
            switch (g)
            {
                case "Y":
                    MainMenu.Spin(table, bet, deposit, spins);
                    break;
                case "N":
                    Console.WriteLine("Ευχαριστουμε πολυ");
                    Console.Clear();
                    MainMenu.Menu();
                    break;
                default:
                    Console.WriteLine("Καντε μια επιλογη");
                    PlayAgain(bet,deposit,spins,table);
                    break;
            }
        }
    }
}
