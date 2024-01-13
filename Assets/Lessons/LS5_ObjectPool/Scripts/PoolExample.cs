using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lessons.LS5_ObjectPool.Scripts
{
    public class PoolExample : MonoBehaviour
    {
        [SerializeField] private int _poolCount = 10;
        [SerializeField] private bool _autoExpand = false;
        [SerializeField] private TestCubePrefab _cubePrefab;

        private PoolMono<TestCubePrefab> pool;

        private void Start()
        {
            pool = new PoolMono<TestCubePrefab>(_cubePrefab, _poolCount, transform);
            pool.autoExpand = this._autoExpand;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                CreateCube();
        }

        private void CreateCube()
        {
            var rX = Random.Range(-5f, 5f);
            var rZ = Random.Range(-5f, 5f);
            var rY = 0;

            var rPosition = new Vector3(rX, rY, rZ);
            var cube = pool.GetFreeElement();
            cube.transform.position = rPosition;

        }
    }
}