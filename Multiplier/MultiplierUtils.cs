using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplier
{
    public interface IMultiplierUtils
    {
        // properties and methods for getting user input and doing the calculation
        int MyInteger { get; set; }
        int MyMultiplier { get; set; }
        void GetUserInt();
        void GetUserMultiplier();
    }

    public class MultiplierUtils : IMultiplierUtils
    {
        // set up the properties where values will be stored
        public int MyInteger { get; set; }
        public int MyMultiplier { get; set; }
        public int MyAnswer { get; set; }

        // define method to get an integer from the user
        public void GetUserInt()
        {
            Console.WriteLine("Enter a number:");
            MyInteger = Convert.ToInt32(Console.ReadLine());
        }

        // define method to get the 'multiplier' from the user
        public void GetUserMultiplier()
        {
            Console.WriteLine("Enter a number to multiply it by:");
            MyMultiplier = Convert.ToInt32(Console.ReadLine());
        }
    }
}
