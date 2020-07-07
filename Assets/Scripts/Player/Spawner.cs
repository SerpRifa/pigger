using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform SpawnPosition;
    public GameObject Enemy;
    public float Time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

 
    void Repeat()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(Time);
        Instantiate(Enemy, SpawnPosition.position, Quaternion.identity);
        Repeat();
    }
}
