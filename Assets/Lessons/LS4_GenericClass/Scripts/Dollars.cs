using System;
using System.Numerics;

namespace Lessons.LS4_GenericClass.Scripts
{
    public class Dollars: Currency<BigInteger>
    {
        public override event Action<BigInteger> OnValueChangedEvent;
        
        public Dollars()
        {
            this.value = new BigInteger(0);
        }

        public override void Add(BigInteger amount)
        {
            
        }

        public override void Spend(BigInteger amount)
        {
            
        }
    }
}