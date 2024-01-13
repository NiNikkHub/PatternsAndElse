namespace Lessons.LS9_Decorator.Scripts
{
    public class Ability: IAbility
    {
        private int _damage;
        private DamageType _damageType;

        public Ability(int damage, DamageType damageType)
        {
            _damage = damage;
            _damageType = damageType;
        }
        
        public int GetDamage()
        {
            return _damage;
        }

        public DamageType GetDamageType()
        {
            return _damageType;
        }

        public void ApplyDamage(ICanBeDamaged canBeDamaged)
        {
            canBeDamaged.TakeDamage(_damageType, _damage);
        }
    }
}