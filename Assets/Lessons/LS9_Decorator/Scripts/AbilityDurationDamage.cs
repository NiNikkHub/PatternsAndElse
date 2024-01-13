using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Lessons.LS9_Decorator.Scripts
{
    public class AbilityDurationDamage: AbilityUpgrade
    {
        private float _duration;
        private int _partsAmount;
        
        public AbilityDurationDamage(IAbility ability, float duration, int partsAmount) : base(ability)
        {
            _duration = duration;
            _partsAmount = partsAmount;
        }

        public override void ApplyDamage(ICanBeDamaged canBeDamaged)
        {
            ApplyDamageAsync(canBeDamaged);
        }

        private async void ApplyDamageAsync(ICanBeDamaged canBeDamaged)
        {
            int damage = Mathf.CeilToInt(MainAbility.GetDamage() / (float)_partsAmount);
            float partDuration = _duration / _partsAmount;
            
            for (int i = 0; i < _partsAmount; i++)
            {
                canBeDamaged.TakeDamage(MainAbility.GetDamageType(), damage);
                
                float duration = partDuration * 1000;
                await Task.Delay((int)duration);
            }
        }
    }
}