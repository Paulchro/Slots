using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slots
{
    public class Lines
    {
        public static void One(double bet, List<string> one, List<string[]> reels, ref string what, ref double result)
        {
            if ((reels[0][0] == reels[0][1] || (reels[0][0] == "Wild" || reels[0][1] == "Wild")) && (reels[0][1] == reels[0][2] || reels[0][0] == reels[0][2] || reels[0][2] == "Wild"))
            {

                one.Add(reels[0][0]);
                one.Add(reels[0][1]);
                one.Add(reels[0][2]);

                if (reels[0][0] == reels[0][3] || reels[0][1] == reels[0][3] || reels[0][2] == reels[0][3] || reels[0][3] == "Wild")
                {
                    one.Add(reels[0][3]);

                    if (reels[0][0] == reels[0][4] || reels[0][1] == reels[0][4] || reels[0][2] == reels[0][4] || reels[0][3] == reels[0][4] || reels[0][4] == "Wild")
                    {
                        one.Add(reels[0][4]);
                    }
                }


                for (int i = 0; i < one.Count; i++)
                {
                    if (one[i].Equals("Star"))
                    {
                        what = "Star";
                        break;
                    }
                    if (one[i].Equals("Bell"))
                    {
                        what = "Bell";
                        break;
                    }
                    if (one[i].Equals("Seven"))
                    {
                        what = "Seven";
                        break;
                    }
                    if (one[i].Equals("Cherry"))
                    {
                        what = "Cherry";
                        break;
                    }
                    if (one[i].Equals("Bar"))
                    {
                        what = "Bar";
                        break;
                    }
                    if (one[i].Equals("King"))
                    {
                        what = "King";
                        break;
                    }
                    if (one[i].Equals("Queen"))
                    {
                        what = "Queen";
                        break;
                    }
                    if (one[i].Equals("Jack"))
                    {
                        what = "Jack";
                        break;
                    }
                    else
                        what = "Wild";

                }
                switch (what)
                {
                    case "Star":
                        result += 10 * one.Count * bet;
                        break;
                    case "Bell":
                        result += 8 * one.Count * bet;
                        break;
                    case "Seven":
                        result += 7 * one.Count * bet;
                        break;
                    case "Cherry":
                        result += 6 * one.Count * bet;
                        break;
                    case "Bar":
                        result += 5 * one.Count * bet;
                        break;
                    case "King":
                        result += 4 * one.Count * bet;
                        break;
                    case "Queen":
                        result += 3 * one.Count * bet;
                        break;
                    case "Jack":
                        result += 2 * one.Count * bet;
                        break;
                }
            }
        }

        public static void Two(double bet, List<string> two, List<string[]> reels, ref string what, ref double result)
        {
            if ((reels[0][0] == reels[1][1] || (reels[0][0] == "Wild" || reels[1][1] == "Wild")) && (reels[1][1] == reels[2][2] || reels[0][0] == reels[2][2] || reels[2][2] == "Wild"))
            {

                two.Add(reels[0][0]);
                two.Add(reels[1][1]);
                two.Add(reels[2][2]);

                if (reels[2][2] == reels[1][3] || reels[1][1] == reels[1][3] || reels[0][0] == reels[1][3] || reels[1][3] == "Wild")
                {
                    two.Add(reels[1][3]);

                    if (reels[0][4] == reels[1][3] || reels[0][4] == reels[2][2] || reels[0][4] == reels[1][1] || reels[0][4] == reels[0][0] || reels[0][4] == "Wild")
                    {
                        two.Add(reels[0][4]);
                    }
                }


                for (int i = 0; i < two.Count; i++)
                {
                    if (two[i].Equals("Star"))
                    {
                        what = "Star";
                        break;
                    }
                    if (two[i].Equals("Bell"))
                    {
                        what = "Bell";
                        break;
                    }
                    if (two[i].Equals("Seven"))
                    {
                        what = "Seven";
                        break;
                    }
                    if (two[i].Equals("Cherry"))
                    {
                        what = "Cherry";
                        break;
                    }
                    if (two[i].Equals("Bar"))
                    {
                        what = "Bar";
                        break;
                    }
                    if (two[i].Equals("King"))
                    {
                        what = "King";
                        break;
                    }
                    if (two[i].Equals("Queen"))
                    {
                        what = "Queen";
                        break;
                    }
                    if (two[i].Equals("Jack"))
                    {
                        what = "Jack";
                        break;
                    }
                    else
                        what = "Wild";


                }
                switch (what)
                {
                    case "Star":
                        result += 10 * two.Count * bet;
                        break;
                    case "Bell":
                        result += 8 * two.Count * bet;
                        break;
                    case "Seven":
                        result += 7 * two.Count * bet;
                        break;
                    case "Cherry":
                        result += 6 * two.Count * bet;
                        break;
                    case "Bar":
                        result += 5 * two.Count * bet;
                        break;
                    case "King":
                        result += 4 * two.Count * bet;
                        break;
                    case "Queen":
                        result += 3 * two.Count * bet;
                        break;
                    case "Jack":
                        result += 2 * two.Count * bet;
                        break;
                }
            }
        }

        public static void Three(double bet, List<string> three, List<string[]> reels, ref string what, ref double result)
        {
            if ((reels[2][0] == reels[1][1] || (reels[2][0] == "Wild" || reels[1][1] == "Wild")) && (reels[1][1] == reels[0][2] | reels[2][0] == reels[0][2] || reels[0][2] == "Wild"))
            {

                three.Add(reels[2][0]);
                three.Add(reels[1][1]);
                three.Add(reels[0][2]);

                if (reels[0][2] == reels[1][3] || reels[1][1] == reels[1][3] || reels[2][0] == reels[1][3] || reels[1][3] == "Wild")
                {
                    three.Add(reels[1][3]);

                    if (reels[2][4] == reels[1][3] || reels[2][4] == reels[0][2] || reels[2][4] == reels[1][1] || reels[2][4] == reels[2][0] || reels[2][4] == "Wild")
                    {
                        three.Add(reels[2][4]);
                    }
                }


                for (int i = 0; i < three.Count; i++)
                {
                    if (three[i].Equals("Star"))
                    {
                        what = "Star";
                        break;
                    }
                    if (three[i].Equals("Bell"))
                    {
                        what = "Bell";
                        break;
                    }
                    if (three[i].Equals("Seven"))
                    {
                        what = "Seven";
                        break;
                    }
                    if (three[i].Equals("Cherry"))
                    {
                        what = "Cherry";
                        break;
                    }
                    if (three[i].Equals("Bar"))
                    {
                        what = "Bar";
                        break;
                    }
                    if (three[i].Equals("King"))
                    {
                        what = "King";
                        break;
                    }
                    if (three[i].Equals("Queen"))
                    {
                        what = "Queen";
                        break;
                    }
                    if (three[i].Equals("Jack"))
                    {
                        what = "Jack";
                        break;
                    }
                    else
                        what = "Wild";


                }
                switch (what)
                {
                    case "Star":
                        result += 10 * three.Count * bet;
                        break;
                    case "Bell":
                        result += 8 * three.Count * bet;
                        break;
                    case "Seven":
                        result += 7 * three.Count * bet;
                        break;
                    case "Cherry":
                        result += 6 * three.Count * bet;
                        break;
                    case "Bar":
                        result += 5 * three.Count * bet;
                        break;
                    case "King":
                        result += 4 * three.Count * bet;
                        break;
                    case "Queen":
                        result += 3 * three.Count * bet;
                        break;
                    case "Jack":
                        result += 2 * three.Count * bet;
                        break;
                }
            }
        }

        public static void Four(double bet, List<string> four, List<string[]> reels, ref string what, ref double result)
        {
            if ((reels[1][0] == reels[1][1] || (reels[1][0] == "Wild" || reels[1][1] == "Wild")) && (reels[1][1] == reels[1][2] || reels[1][0] == reels[1][2] || reels[1][2] == "Wild"))
            {

                four.Add(reels[1][0]);
                four.Add(reels[1][1]);
                four.Add(reels[1][2]);

                if (reels[1][2] == reels[1][3] || reels[1][1] == reels[1][3] || reels[1][0] == reels[1][3] || reels[1][3] == "Wild")
                {
                    four.Add(reels[1][3]);

                    if (reels[1][0] == reels[1][4] || reels[1][1] == reels[1][4] || reels[1][2] == reels[1][4] || reels[1][3] == reels[1][4] || reels[1][4] == "Wild")
                    {
                        four.Add(reels[1][4]);
                    }
                }


                for (int i = 0; i < four.Count; i++)
                {
                    if (four[i].Equals("Star"))
                    {
                        what = "Star";
                        break;
                    }
                    if (four[i].Equals("Bell"))
                    {
                        what = "Bell";
                        break;
                    }
                    if (four[i].Equals("Seven"))
                    {
                        what = "Seven";
                        break;
                    }
                    if (four[i].Equals("Cherry"))
                    {
                        what = "Cherry";
                        break;
                    }
                    if (four[i].Equals("Bar"))
                    {
                        what = "Bar";
                        break;
                    }
                    if (four[i].Equals("King"))
                    {
                        what = "King";
                        break;
                    }
                    if (four[i].Equals("Queen"))
                    {
                        what = "Queen";
                        break;
                    }
                    if (four[i].Equals("Jack"))
                    {
                        what = "Jack";
                        break;
                    }
                    else
                        what = "Wild";


                }
                switch (what)
                {
                    case "Star":
                        result += 10 * four.Count * bet;
                        break;
                    case "Bell":
                        result += 8 * four.Count * bet;
                        break;
                    case "Seven":
                        result += 7 * four.Count * bet;
                        break;
                    case "Cherry":
                        result += 6 * four.Count * bet;
                        break;
                    case "Bar":
                        result += 5 * four.Count * bet;
                        break;
                    case "King":
                        result += 4 * four.Count * bet;
                        break;
                    case "Queen":
                        result += 3 * four.Count * bet;
                        break;
                    case "Jack":
                        result += 2 * four.Count * bet;
                        break;
                }
            }
        }

        public static void Five(double bet, List<string> five, List<string[]> reels, ref string what, ref double result)
        {
            if ((reels[2][0] == reels[2][1] || (reels[2][0] == "Wild" || reels[2][1] == "Wild")) && (reels[2][1] == reels[2][2] || reels[2][0] == reels[2][2] || reels[2][2] == "Wild"))
            {

                five.Add(reels[2][0]);
                five.Add(reels[2][1]);
                five.Add(reels[2][2]);

                if (reels[2][2] == reels[2][3] || reels[2][1] == reels[2][3] || reels[2][0] == reels[2][3] || reels[2][3] == "Wild")
                {
                    five.Add(reels[2][3]);
                    if (reels[2][0] == reels[2][4] || reels[2][1] == reels[2][4] || reels[2][2] == reels[2][4] || reels[2][3] == reels[2][4] || reels[2][4] == "Wild")
                    {
                        five.Add(reels[2][4]);
                    }
                }


                for (int i = 0; i < five.Count; i++)
                {
                    if (five[i].Equals("Star"))
                    {
                        what = "Star";
                        break;
                    }
                    if (five[i].Equals("Bell"))
                    {
                        what = "Bell";
                        break;
                    }
                    if (five[i].Equals("Seven"))
                    {
                        what = "Seven";
                        break;
                    }
                    if (five[i].Equals("Cherry"))
                    {
                        what = "Cherry";
                        break;
                    }
                    if (five[i].Equals("Bar"))
                    {
                        what = "Bar";
                        break;
                    }
                    if (five[i].Equals("King"))
                    {
                        what = "King";
                        break;
                    }
                    if (five[i].Equals("Queen"))
                    {
                        what = "Queen";
                        break;
                    }
                    if (five[i].Equals("Jack"))
                    {
                        what = "Jack";
                        break;
                    }
                    else
                        what = "Wild";


                }
                switch (what)
                {
                    case "Star":
                        result += 10 * five.Count * bet;
                        break;
                    case "Bell":
                        result += 8 * five.Count * bet;
                        break;
                    case "Seven":
                        result += 7 * five.Count * bet;
                        break;
                    case "Cherry":
                        result += 6 * five.Count * bet;
                        break;
                    case "Bar":
                        result += 5 * five.Count * bet;
                        break;
                    case "King":
                        result += 4 * five.Count * bet;
                        break;
                    case "Queen":
                        result += 3 * five.Count * bet;
                        break;
                    case "Jack":
                        result += 2 * five.Count * bet;
                        break;
                }
            }
        }
    }
}
