using System;
using UnityEngine;

namespace Lessons.LS11_Abstract_Factory.Scripts
{
    public class ExampleSpawnerFactory: MonoBehaviour
    {
        private ISpawnerFactory _factory;

        private void Start()
        {
            SetModeLocal();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                SetModeLocal();
            
            if (Input.GetMouseButtonDown(1))
                SetModeNetwork();

            if (Input.GetKeyDown(KeyCode.Alpha1))
                _factory.SpawnUnit();
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                _factory.SpawnInteractableObject();
            
            if (Input.GetKeyDown(KeyCode.Alpha3))
                _factory.SpawnPlayer();
        }

        private void SetModeLocal()
        {
            _factory = new LocalSpawnerFactory();
            
            Debug.Log("Local mode enabled");
        }   
        
        private void SetModeNetwork()
        {
            _factory = new NetworkSpawnerFactory();
            
            Debug.Log("Network mode enabled");
        }
    }
}