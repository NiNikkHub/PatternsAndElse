using System;
using UnityEngine;

namespace Lessons.LS2_Singleton.Scripts
{
    public class SingletonTester: MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                GameManager.instance.Debug();
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                Bank.instance.Debug();
        }
    }
}