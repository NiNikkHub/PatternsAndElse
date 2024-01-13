using UnityEngine;

namespace Lessons.LS6_ScriptableObject.Scripts
{
    public class Example : MonoBehaviour
    {
        private void Start()
        {
            var allChestInfo = Resources.LoadAll<ChestInfo>("");
            foreach (var chestInfo in allChestInfo)
            {
                Debug.Log($"ID of chestInfo is {chestInfo.id}");
                Debug.Log($"Name of chestInfo is {chestInfo.name}");
            }
        }
        
    }
}