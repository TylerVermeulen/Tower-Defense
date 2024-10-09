using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTravel : MonoBehaviour
{
    internal GameObject target;
    [SerializeField] private float movespeed;
    public int damage;

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movespeed * Time.deltaTime);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
