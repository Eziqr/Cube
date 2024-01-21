using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.5f;
    void Start()
    {
        health += level;
        print("Здоровье игрока:" + health);
    }
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        newPosition.y += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
