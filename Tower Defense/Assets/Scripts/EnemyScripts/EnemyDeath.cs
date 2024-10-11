using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private int health;

    void Start()
    {
        health = this.GetComponent<EnemyStats>().Health;
        Debug.Log("health"+health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "bullet")
        {
            Debug.Log("BulletTouched");
            health -= collision.GetComponent<BulletTravel>().Damage;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
