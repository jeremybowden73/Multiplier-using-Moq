using System;
using Microsoft.Extensions.DependencyInjection;

namespace Multiplier
{
    class Program
    {
        public static void Main(string[] args)
        {
            // configure the dependency injection container to provide objects
            // when interfaces are requested
            var serviceProvider = new ServiceCollection()
                   .AddTransient<IMultiply, Multiply>()
                   .AddTransient<IMultiplierUtils, MultiplierUtils>()
                   .BuildServiceProvider();

            Console.Clear();

            // create a "Result Object" of type Multiply, by requesting an "empty"
            // Multiply object from the serviceProvider, then
            // invoke the multiplying method and store the result as Result
            var ResultObj = serviceProvider.GetService<IMultiply>();

            // invoke the Multiply method that asks the user for two ints
            ResultObj.PopulateMultUtils();

            // invoke the Multiply method that does the maths
            var Result = ResultObj.MultiplyTwoInts();
            Console.WriteLine($"Answer is... {Result}");
        }
    }
}
