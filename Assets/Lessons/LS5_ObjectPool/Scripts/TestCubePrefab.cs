using System.Collections;
using UnityEngine;

namespace Lessons.LS5_ObjectPool.Scripts
{
    public class TestCubePrefab : MonoBehaviour
    {
        [SerializeField] private float _lifeTime = 2;

        private void OnEnable()
        {
            StartCoroutine(nameof(LifeRoutine));
        }

        private void OnDisable()
        {
            StopCoroutine(nameof(LifeRoutine));
        }

        private IEnumerator LifeRoutine()
        {
            yield return new WaitForSecondsRealtime(_lifeTime);
            
            gameObject.SetActive(false);
        }
    }
}