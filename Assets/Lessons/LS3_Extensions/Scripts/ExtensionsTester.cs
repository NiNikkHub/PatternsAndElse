using System;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.LS3_Extensions.Scripts
{
    public class ExtensionsTester: MonoBehaviour
    {
        public Button button;
        public Transform transform;
        
        private void OnEnable()
        {
            button.AddListener(this.OnClick);
        }

        private void OnDisable()
        {
            button.AddListener(this.OnClick);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                transform.Activate();

            if (Input.GetKeyDown(KeyCode.Alpha2))
                transform.Deactivate();

            if (Input.GetKeyDown(KeyCode.Alpha3))
                transform.Destroy();    
        }

        private void OnClick()
        {
            Debug.Log("On Button clicked");
        }
    }
}