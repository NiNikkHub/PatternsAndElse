using UnityEngine;

namespace Lessons.LS9_Decorator.Scripts
{
    public class UnitExample: MonoBehaviour, ICanBeDamaged
    {
        [SerializeField] private DecoratorExampleControllerUI _ui;
        public void TakeDamage(DamageType type, int damage)
        {
            _ui.CreateWidgetDamageValue(type, damage);
            
            Debug.Log($"Damage received. Type: {type}, Damage: {damage}");
        }
    }
}