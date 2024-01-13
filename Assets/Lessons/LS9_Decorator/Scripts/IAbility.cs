namespace Lessons.LS9_Decorator.Scripts
{
    public interface IAbility
    {
        int GetDamage();
        DamageType GetDamageType();
        void ApplyDamage(ICanBeDamaged canBeDamaged);
    }
}
