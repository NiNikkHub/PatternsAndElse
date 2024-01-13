using TMPro;
using UnityEngine;

namespace Lessons.LS9_Decorator.Scripts
{
    public class WidgetDamageValue : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textValue;

        public void SetValue(string newValue)
        {
            _textValue.text = newValue;
        }

        public void SetColor(Color color)
        {
            _textValue.color = color;
        }

        private void HandleAnimationOver()
        {
            Destroy(gameObject);
        }
    }
}
