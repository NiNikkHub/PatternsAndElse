using UnityEngine;
using UnityEngine.UI;

namespace Lessons.LS6_ScriptableObject.Scripts
{
    [CreateAssetMenu(fileName = "ChestInfo", menuName = "Gameplay/New ChestInfo")]
    public class ChestInfo: ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Image _icon;

        public string id => _id;
        public string name => _name;
        public GameObject pregab => _prefab;
        public Image icon => _icon;
    }
}