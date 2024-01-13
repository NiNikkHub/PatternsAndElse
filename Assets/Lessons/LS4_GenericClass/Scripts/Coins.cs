using System;

namespace Lessons.LS4_GenericClass.Scripts
{
    public class Coins : Currency<int>
    {
        public override event Action<int> OnValueChangedEvent;
        
        public Coins()
        {
            this.value = 0;
        }
        
        public override void Add(int amount)
        {
            
        }

        public override void Spend(int amount)
        {
            
        }
    }
}