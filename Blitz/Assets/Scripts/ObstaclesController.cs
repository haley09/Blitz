using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesController : MonoBehaviour 
{
    public float speed = 500f;

    void Update()
    {

        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;

        if (transform.position.x < -1025)
            gameObject.SetActive(false);

    }

} 









