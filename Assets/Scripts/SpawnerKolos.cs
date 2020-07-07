using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerKolos : MonoBehaviour
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
        float smeshenie = 0.5F;
        yield return new WaitForSeconds(Time);
        Instantiate(Enemy, SpawnPosition.position, Quaternion.identity);
        Vector3 second = new Vector3(SpawnPosition.position.x + smeshenie, SpawnPosition.position.y);
        Instantiate(Enemy, second, Quaternion.identity);
        Vector3 three = new Vector3(SpawnPosition.position.x + 2*smeshenie, SpawnPosition.position.y);
        Instantiate(Enemy, three, Quaternion.identity);
        Repeat();
    }
}
