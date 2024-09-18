using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
    public GameObject path;
    public GameObject healthsystem;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float movespeed;
    private int waypointindex;
    // Start is called before the first frame update
    void Start()
    {
        ApplyWaypoints();
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
            transform.position = Vector3.MoveTowards(transform.position,
            waypoints[waypointindex].transform.position, 
            movespeed * Time.deltaTime);
            
            if (transform.position == waypoints[waypointindex].transform.position)
            {
                if (waypointindex == waypoints.Length)
                {

                }
                waypointindex++;
            }
            
        }
    }
    private void ApplyWaypoints()
    {
        int j = 0;
        
        for (int i = 0;i < 26; i++)
        {
            waypoints[i] = path.transform.GetChild(j).transform;
            j++;
        }
    }
}
