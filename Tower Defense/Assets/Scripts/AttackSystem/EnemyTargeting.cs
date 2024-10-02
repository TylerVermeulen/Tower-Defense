using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> EnemiesInRange = new List<GameObject>();
    private GameObject Target;
    [SerializeField] private GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null) 
        {
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Debug.Log("EnemiesInRange" );
        EnemiesInRange.Add(collision.gameObject);
        Target = EnemiesInRange[0];
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EnemiesInRange.Remove(collision.gameObject);
        if (Target == collision.gameObject)
        {
            Target = EnemiesInRange[0];
        }
    }
}
