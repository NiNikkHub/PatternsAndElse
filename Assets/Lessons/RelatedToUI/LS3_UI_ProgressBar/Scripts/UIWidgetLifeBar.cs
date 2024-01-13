using System;
using UnityEngine;

namespace Lessons.RelatedToUI.LS3_UI_ProgressBar.Scripts
{
    public class UIWidgetLifeBar : MonoBehaviour
    {
        [SerializeField] private ProgressBar _progressBar;

        private void OnEnable()
        {
            var example = FindObjectOfType<TestExample>();
            _progressBar.SetValue(example.healthNormalized);

            example.OnPlayerHealthValueChangedEvent += OnPlayerHealthValueChanged;
        }

        private void OnPlayerHealthValueChanged(float newValueNormalized)
        {
            _progressBar.SetValue(newValueNormalized);
        }

        private void OnDisable()
        {
            var example = FindObjectOfType<TestExample>();
            
            if (example)
                example.OnPlayerHealthValueChangedEvent -= OnPlayerHealthValueChanged;
        }
    }
}
