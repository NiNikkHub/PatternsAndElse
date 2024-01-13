using UnityEngine;

namespace Lessons.LS12_Command.Scripts
{
    public class MoveStraightComand: MoveComand
    {
        public MoveStraightComand(Transform transform, float stepDisctance = 1) : base(transform, stepDisctance)
        {
        }

        public override void Execute()
        {
            _transform.position += Vector3.right * _stepDisctance;
        }

        public override void Undo()
        {
            _transform.position -= Vector3.right * _stepDisctance; 
        }
    }
}