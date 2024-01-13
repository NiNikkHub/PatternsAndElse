using UnityEngine.Events;
using UnityEngine.UI;

namespace Lessons.LS3_Extensions.Scripts
{
    public static class ButtonExtensions
    {

        public static void AddListener(this Button button, UnityAction callback)
        {
            button.onClick.AddListener(callback);
        }
        
        public static void RemoveListener(this Button button, UnityAction callback)
        {
            button.onClick.RemoveListener(callback);
        }

        public static void RemoveAllListener(this Button button)
        {
            button.onClick.RemoveAllListeners();
        }
    }
}
