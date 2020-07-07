using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStar : MonoBehaviour
{
    public float Speed;
    public Vector2 Dir;
    protected float k;

    MoveStar()
    {
        System.Random rnd = new System.Random();
        int number = rnd.Next(1, 10);//
        if (number <= 7)
            k = 1;
        if (number > 7)
            k = 1.5f;
        if (number == 10)
            k = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Dir * Speed*k, Space.World);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
