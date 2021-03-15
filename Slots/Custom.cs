using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slots
{
    public class Custom
    {
        private double _bet;
        private double _deposit;
        public double Bet
        {
            get
            {
                return _bet;
            }
            set
            {
                _bet = value;
            }
        }
        public double Deposit
        {
            get
            {
                return _deposit;
            }
            set
            {
                _deposit = value;
            }
        }

        public Custom()
        {
        }
        public double ConvertToDouble(string dValue)
        {

            bool isItDouble;
            double d1;
            isItDouble = double.TryParse(dValue, out d1);


            while (dValue == null || isItDouble == false)
            {
                Console.Write("Please enter a valid number");
                dValue = Console.ReadLine();
                isItDouble = double.TryParse(dValue, out d1);
            }
            d1 = double.Parse(dValue, CultureInfo.InvariantCulture);
            return (d1);
        }

        public int ConvertToInt(string intValue)
        {

            bool isItInt;
            int i1;
            isItInt = int.TryParse(intValue, out i1);


            while (intValue == null || isItInt == false)
            {
                Console.Write("Please enter a valid number");
                intValue = Console.ReadLine();
                isItInt = int.TryParse(intValue, out i1);
            }
            i1 = int.Parse(intValue);
            return (i1);
        }
    }
}
