using UnityEngine;

namespace Lessons.LS12_Command.Scripts
{
    public abstract class MoveComand
    {
        protected Transform _transform;
        protected float _stepDisctance;

        public MoveComand(Transform transform, float stepDisctance = 1f)
        {
            _transform = transform;
            _stepDisctance = stepDisctance;
        }
        
        public abstract void Execute();
        public abstract void Undo();
    }
}