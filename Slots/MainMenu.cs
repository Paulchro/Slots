using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Slots
{
    public class MainMenu
    {
        public static void Menu()
        {
            Custom custom = new Custom();
            var table = new List<string>() { "Wild", "Star", "Bell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack", "!BONUS!" };
            Console.WriteLine("---Καλωςηρθατε στο παιχνιδι μας!---\n");
            Console.WriteLine("Καντε μια καταθεση");
            custom.Deposit = custom.ConvertToDouble(Console.ReadLine());
            Console.WriteLine($"Καταθεσατε: { custom.Deposit}");
            Console.WriteLine();
            Console.WriteLine("Εισαγετε το στοιχημα σας");
            custom.Bet = custom.ConvertToDouble(Console.ReadLine());
            Console.WriteLine($"Το στοιχημα σας: {custom.Bet}");
            Console.WriteLine();
            Console.WriteLine("Ποσα σπιν θελετε να κανετε");
            int spins = custom.ConvertToInt(Console.ReadLine());
            Console.WriteLine($"Επιλεξατε {spins} spins.");
            Console.WriteLine();

            Spin(table, custom.Bet, custom.Deposit, spins);
        }
        public static void NewMenu(double deposit, double bet)
        {
            Custom custom = new Custom();
            var table = new List<string>() { "Wild", "Star", "Bell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack", "!BONUS!" };

            
            Console.WriteLine("Ποσα σπιν θελετε να κανετε");
            int spins = custom.ConvertToInt(Console.ReadLine());
            Console.WriteLine($"Επιλεξατε {spins} spins.");
            Console.WriteLine();

            Spin(table, bet, deposit, spins);
        }
        public static void Spin(List<string> table, double bet, double deposit, int spins)
        {
            table = new List<string>() { "Wild", "Star", "Bell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack", "!BONUS!" };
            for (int y = 0; y < spins; y++)
            {
                List<string> one, two, three, four, five;
                List<string[]> reels;
                Spins(table, y, out one, out two, out three, out four, out five, out reels, spins);

                

                string what = "";
                double result = 0;
                Lines.One(bet, one, reels, ref what, ref result);

                Lines.Two(bet, two, reels, ref what, ref result);

                Lines.Three(bet, three, reels, ref what, ref result);

                Lines.Four(bet, four, reels, ref what, ref result);

                Lines.Five(bet, five, reels, ref what, ref result);

                int count = 0;
                
               

                if (result > 0)
                {
                    deposit = deposit + result - bet;
                    Console.WriteLine($"You won {result}! You now have {deposit}");
                    foreach (var item in reels[0])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    foreach (var item in reels[1])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    foreach (var item in reels[2])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    if (count > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------");
                        Thread.Sleep(2000);
                        Console.WriteLine("Bonus round, +10 spins enabled");
                        Console.WriteLine("Wins pay x3!");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        BonusRound.Bonus(bet, deposit, spins - y);

                        break;
                    }
                }

                else
                {
                    deposit -= bet;
                    Console.WriteLine($"Nothing, balance: {deposit} ");
                    foreach (var item in reels[0])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    foreach (var item in reels[1])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    foreach (var item in reels[2])
                    {
                        if (item == "!BONUS!")
                            count++;
                    }
                    if (count > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------");
                        Thread.Sleep(2000);
                        Console.WriteLine("Bonus round, +10 spins enabled");
                        Console.WriteLine("Wins pay x3!");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        BonusRound.Bonus(bet, deposit, spins - y);

                        break;
                    }
                    if (deposit <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Τα χρηματα σας τελειωσαν, θελετε να ξαναπαιξετε? Y/N");
                        Console.ResetColor();
                        NewPlay();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Τα σπιν τελειωσαν, Θελετε να παιξετε παλι? Y/N");
            Console.ResetColor();
            PlayAgain(deposit, bet);
        }

        private static void NewPlay()
        {
            string g = Console.ReadLine();

            switch (g)
            {
                case "Y":
                    Menu();
                    break;
                case "N":
                    Console.WriteLine("Ευχαριστουμε πολυ");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Καντε μια επιλογη");
                    NewPlay();
                    break;
            }
        }

        private static void PlayAgain(double deposit, double bet)
        {
            string g = Console.ReadLine();
            switch (g)
            {
                case "Y":
                    NewMenu(deposit,bet);
                    break;
                case "N":
                    Console.WriteLine("Ευχαριστουμε πολυ");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    PlayAgain(deposit, bet);
                    Console.WriteLine("Καντε μια επιλογη");
                    break;
            }
        }

        public static void Spins(List<string> table, int y, out List<string> one, out List<string> two, out List<string> three, out List<string> four, out List<string> five, out List<string[]> reels, int spins)
        {
            one = new List<string>();
            two = new List<string>();
            three = new List<string>();
            four = new List<string>();
            five = new List<string>();
            Random rnd = new Random();
            reels = new List<string[]>();
            reels.Add(table.OrderBy(x => rnd.Next()).Take(5).ToArray());
            reels.Add(table.OrderBy(x => rnd.Next()).Take(5).ToArray());
            reels.Add(table.OrderBy(x => rnd.Next()).Take(5).ToArray());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" --------------------- No {spins - y} spin ---------------------");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var item in reels[0])
            {
                if (item == "!BONUS!")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\n");
            foreach (var item in reels[1])
            {
                if (item == "!BONUS!")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\n");
            foreach (var item in reels[2])
            {
                if (item == "!BONUS!")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(String.Format("{0,10}", item));
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\n");
            Thread.Sleep(1000);
        }


    }
}
