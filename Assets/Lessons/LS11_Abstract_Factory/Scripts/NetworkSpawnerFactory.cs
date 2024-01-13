using UnityEngine;

namespace Lessons.LS11_Abstract_Factory.Scripts
{
    public class NetworkSpawnerFactory: ISpawnerFactory
    {
        public IUnit SpawnUnit()
        {
            var gameObject = new GameObject("Unit [NET]");
            var unit = gameObject.AddComponent<Unit>();

            gameObject.AddComponent<NetworkBehaviour>();

            return unit;
        }

        public IInteractableObject SpawnInteractableObject()
        {
            var gameObject = new GameObject("IntercatableObject [NET]");
            var interactableObject = gameObject.AddComponent<InteractableObject>();

            gameObject.AddComponent<NetworkBehaviour>();
            
            return interactableObject;
        }

        public IUnit SpawnPlayer()
        {
            var gameObject = new GameObject("Player [NET]");
            var unit = gameObject.AddComponent<Unit>();
            
            gameObject.AddComponent<Player>();
            gameObject.AddComponent<NetworkBehaviour>();
            
            return unit;
        }
    }
}