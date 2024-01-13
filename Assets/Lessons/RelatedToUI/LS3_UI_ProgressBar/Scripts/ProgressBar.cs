using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.RelatedToUI.LS3_UI_ProgressBar.Scripts
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Image _imageFiller;
        [SerializeField] private TMP_Text _textValue;

        public void SetValue(float valueNormalized)
        {
            _imageFiller.fillAmount = valueNormalized;

            var valueInPercent = Mathf.RoundToInt(valueNormalized * 100f);
            _textValue.text = $"{valueInPercent}%";
        }
    }
}
