namespace Lessons.LS11_Abstract_Factory.Scripts
{
    public interface ISpawnerFactory
    {
        IUnit SpawnUnit();
        IInteractableObject SpawnInteractableObject();
        IUnit SpawnPlayer();
    }
}