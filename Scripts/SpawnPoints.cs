using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private float _delay;

    private SpawnPoint[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
    }

    private void Start()
    {
        Coroutine spawner = StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        var delay = new WaitForSeconds(_delay);
        bool isFinish = false;
        int index = 0;

        while (isFinish == false)
        {
            SpawnPoint selectedPoint = _spawnPoints[index];

            selectedPoint.SpawnEnemy();
            index++;

            if (index == _spawnPoints.Length)
                index = 0;

            yield return delay;
        }
    }
}
