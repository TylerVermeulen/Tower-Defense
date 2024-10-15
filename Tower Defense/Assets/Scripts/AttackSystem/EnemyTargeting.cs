using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    
    [SerializeField]private List<GameObject> EnemiesInRange = new List<GameObject>();
    [SerializeField]internal GameObject target;
    [SerializeField]private GameObject Bullet;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") 
        { 
            EnemiesInRange.Add(collision.gameObject);
            target = EnemiesInRange[0];
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            EnemiesInRange.Remove(collision.gameObject);
            if (target == collision.gameObject)
            {
                if (EnemiesInRange.Count != 0) 
                {
                    target = EnemiesInRange[0]; 
                }
                else
                {
                    target = null;
                }
            }
        }
    }
}
