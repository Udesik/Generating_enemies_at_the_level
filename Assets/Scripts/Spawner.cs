using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private float _delay = 2f;
    [SerializeField] private Enemy _prefab;
    
    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        var wait = new WaitForSeconds(_delay);
        
        while (true)
        {
            int indexSpawn = Random.Range(0, _spawnPoints.Count);
            Transform spawnPoint = _spawnPoints[indexSpawn];

            Enemy enemy = Instantiate(_prefab, spawnPoint.position, Quaternion.identity);
            
            Vector3 direction = spawnPoint.forward; 
            enemy.SetDirection(direction);
            
            yield return wait;
        }
    }
}
