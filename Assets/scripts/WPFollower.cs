using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPFollower : MonoBehaviour
{
    [SerializeField] GameObject[] WP;
    int currentWayPointIndex = 0;


    [SerializeField] float Speed = 1f;


    void Update()
    {
        if (Vector3.Distance(transform.position, WP[currentWayPointIndex].transform.position) < .1f) 
        {
            currentWayPointIndex ++;
            if (currentWayPointIndex >= WP.Length)
            {
            currentWayPointIndex= 0;


            }
        }
        transform.position = Vector3.MoveTowards(transform.position, WP[currentWayPointIndex].transform.position, Speed * Time.deltaTime);
    }
}
