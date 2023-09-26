using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] SpawnPoint[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
           Enemy enemy  =  Instantiate(spawnPoint.Enemy,spawnPoint.transform.position,Quaternion.identity);
            enemy.Initialize(spawnPoint.Target);
        }

        yield return null;
    }
}
