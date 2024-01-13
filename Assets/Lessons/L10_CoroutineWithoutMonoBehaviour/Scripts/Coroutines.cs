using System.Collections;
using UnityEngine;

namespace Lessons.L10_CoroutineWithoutMonoBehaviour.Scripts
{
    public sealed class Coroutines: MonoBehaviour
    {
        private static Coroutines instance
        {
            get
            {
                if (m_instance == null)
                {
                    var gameObject = new GameObject("[COROUTINE MANAGER]");
                    m_instance = gameObject.AddComponent<Coroutines>();
                    DontDestroyOnLoad(gameObject);
                }

                return m_instance;
            }
        }

        private static Coroutines m_instance;

        public static Coroutine StartRoutine(IEnumerator enumerator)
        {
            return instance.StartCoroutine(enumerator);
        }

        public static void StopRoutine(Coroutine routine)
        {
            if (routine != null)
                instance.StopCoroutine(routine);
        }
        
    }
}