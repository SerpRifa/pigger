using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerStar : MonoBehaviour
{

    public Transform SpawnPosition;
    public GameObject Star;
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
        Instantiate(Star, SpawnPosition.position, Quaternion.identity);
        Repeat();
    }
}
