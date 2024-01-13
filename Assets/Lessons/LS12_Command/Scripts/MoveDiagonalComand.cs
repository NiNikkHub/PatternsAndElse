using UnityEngine;

namespace Lessons.LS12_Command.Scripts
{
    public class MoveDiagonalComand: MoveComand
    {
        private Vector3 directionDiagonal = new Vector3(1f, -1f, 0f).normalized;
        
        public MoveDiagonalComand(Transform transform, float stepDisctance = 1) : base(transform, stepDisctance)
        {
        }

        public override void Execute()
        {
            _transform.position += directionDiagonal * _stepDisctance;
        }

        public override void Undo()
        {
            _transform.position -= directionDiagonal * _stepDisctance;

        }
    }
}