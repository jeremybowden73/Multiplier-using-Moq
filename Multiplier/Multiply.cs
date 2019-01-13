using System;
using System.Collections.Generic;
using System.Text;
using Multiplier;

namespace Multiplier
{
    public interface IMultiply
    {
        int MultiplyTwoInts();
    }

    public class Multiply : IMultiply
    {
        // create a "placeholder name" for the the external class that
        // is needed when a new Multiply object is created
        private readonly IMultiplierUtils _multiplierUtils;

        // constructor injection. When a new Multiply object is created,
        // populate the "placeholder" _multiplierUtils with the IMultiplierUtils
        // object that was passed in during creation
        public Multiply(IMultiplierUtils multUtils)
        {
            _multiplierUtils = multUtils;
        }
        
        // you can now use _multiplierUtils (the object that
        // was passed in to the constructor) in the class methods:
        
        // define method to calculate the product
        public int MultiplyTwoInts()
        {
            int ans = _multiplierUtils.MyInteger * _multiplierUtils.MyMultiplier;
            return ans;
        }
    }
}
