using System;
using UnityEngine;

namespace Lessons.RelatedToUI.LS3_UI_ProgressBar.Scripts
{
    public class TestExample: MonoBehaviour
    {
        public event Action<float> OnPlayerHealthValueChangedEvent;
        
        [SerializeField] private int healthDefault = 100;
        
        public int health { get; private set; }
        public float healthNormalized => (float)health / healthDefault;

        public void Awake()
        {
            health = healthDefault;
            OnPlayerHealthValueChangedEvent?.Invoke(healthNormalized);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                HitPlayer();
        }

        private void HitPlayer()
        {
            health -= 5;
            if (health <= 0)
                gameObject.SetActive(false);
            
            OnPlayerHealthValueChangedEvent?.Invoke(healthNormalized);
        }
    }
}