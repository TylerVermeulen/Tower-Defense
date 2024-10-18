using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
    [SerializeField]private GameObject path;
    private int damage;
    public static event Action<int> onReachedEnd;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float movespeed;
    private int waypointindex;

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public GameObject Path
    {
        get { return path; }
        set { path = value; }
    }
    public int Waypointindex
    {
        get { return waypointindex; }
        set { waypointindex = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        Damage = this.GetComponent<EnemyStats>().Damage;
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
                waypointindex++;
            }
            if (waypointindex == waypoints.Length)
            {
                onReachedEnd?.Invoke(Damage);
                Destroy(this.gameObject);
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
