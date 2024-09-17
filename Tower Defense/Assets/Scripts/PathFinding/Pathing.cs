using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float movespeed;
    private int waypointindex;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointindex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (waypointindex <= waypoints.Length - 1)
        {

        }
    }
}
