using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public float Speed;
    public Vector2 Dir;
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Dir * Speed, Space.World);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
