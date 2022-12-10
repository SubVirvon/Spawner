using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    private Vector2 _position;

    private void Awake()
    {
        _position = transform.position;
    }

    public void SpawnEnemy()
    {   
        Instantiate(_enemyPrefab, new Vector2(_position.x, _position.y), Quaternion.identity);
    }
}
