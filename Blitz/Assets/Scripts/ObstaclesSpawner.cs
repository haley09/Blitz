using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float min_Y = -458f, max_Y = 512f;

    public float delayTimer = 1f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Vector3 temp = transform.position;
            temp.y = Random.Range(min_Y, max_Y);
            int rand = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[rand], temp, obstacles[rand].transform.rotation);
            timer = delayTimer;
        }
    }
}
