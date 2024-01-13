using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.LS12_Command.Scripts
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Button _buttonStraight;
        [SerializeField] private Button _buttonDiagonal;
        [SerializeField] private Button _buttonUndo;
        [SerializeField] private Transform _pivotTransform;
        [SerializeField] private float _stepDistance = 1f;
        
        private Stack<MoveComand> moveJournal = new Stack<MoveComand>();
        
        private void OnEnable()
        {
            _buttonStraight.onClick.AddListener(StepStraight);
            _buttonDiagonal.onClick.AddListener(StepDiagonal);
            _buttonUndo.onClick.AddListener(UndoLastMove);
        }

        private void OnDisable()
        {
            _buttonStraight.onClick.RemoveListener(StepStraight);
            _buttonDiagonal.onClick.RemoveListener(StepDiagonal);
            _buttonUndo.onClick.RemoveListener(UndoLastMove);
        }

        private void StepDiagonal()
        {
            var move = new MoveDiagonalComand(_pivotTransform, _stepDistance);
            move.Execute();
            
            moveJournal.Push(move);

            Debug.Log("Step diagonal");
        }

        private void StepStraight()
        {
            var move = new MoveStraightComand(_pivotTransform, _stepDistance);
            move.Execute();
            
            moveJournal.Push(move);
            
            Debug.Log("Step straight");
        }
        
        private void UndoLastMove()
        {
            if (moveJournal.Count <= 0) return;
            
            var lastMove = moveJournal.Pop();
            lastMove.Undo();
            
            Debug.Log("Undo");
        }
    }
}
