using System;

namespace Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // create a new userNum object
            var userNum = new MultiplierUtils();

            // invoke the method on the object to get a number from the user
            userNum.GetUserInt();

            // invoke the method to get a "multiplier" number
            userNum.GetUserMultiplier();

            // create a "Result Object" of type Multiply, passing to it the
            // userNum object that we've populated.
            // invoke the multiplying method and store the result as Result
            var ResultObj = new Multiply(userNum);
            var Result = ResultObj.MultiplyTwoInts();
            Console.WriteLine($"Answer is... {Result}");
        }
    }
}
