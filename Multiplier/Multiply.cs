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
        // dependency injection of the external class
        private readonly IMultiplierUtils _multiplierUtils;

        public Multiply(IMultiplierUtils multUtils)
        {
            _multiplierUtils = multUtils;
        }
        
        // define method to calculate the product
        public int MultiplyTwoInts()
        {
            int ans = _multiplierUtils.MyInteger * _multiplierUtils.MyMultiplier;
            return ans;
        }
    }
}
