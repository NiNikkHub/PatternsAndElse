using UnityEngine;

namespace Lessons.LS11_Abstract_Factory.Scripts
{
    public class LocalSpawnerFactory: ISpawnerFactory
    {
        public IUnit SpawnUnit()
        {
            var gameObject = new GameObject("Unit [LOCAL]");
            var unit = gameObject.AddComponent<Unit>();

            return unit;
        }

        public IInteractableObject SpawnInteractableObject()
        {
            var gameObject = new GameObject("IntercatableObject [LOCAL]");
            var interactableObject = gameObject.AddComponent<InteractableObject>();

            return interactableObject;
        }

        public IUnit SpawnPlayer()
        {
            var gameObject = new GameObject("Player [LOCAL]");
            var unit = gameObject.AddComponent<Unit>();
            
            gameObject.AddComponent<Player>();
            
            return unit;
        }
    }
}