using System;

namespace Lessons.LS4_GenericClass.Scripts
{
    public abstract class Currency<T>
    {
        public abstract event Action<T> OnValueChangedEvent;
        
        public T value;

        public abstract void Add(T amount);
        public abstract void Spend(T amount);
    }
}
