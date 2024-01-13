using System;
using UnityEngine;

namespace Lessons.LS2_Singleton.Scripts
{
    
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance { get; private set; }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
                return;
            }
            
            Destroy(this.gameObject);
        }

        public void Debug()
        {
            UnityEngine.Debug.Log("GameManager singleton");
        }
    }
}
