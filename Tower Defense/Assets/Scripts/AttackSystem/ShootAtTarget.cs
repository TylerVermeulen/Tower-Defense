using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ShootAtTarget : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    private EnemyTargeting targeting;
    [SerializeField]private float shootcooldown;
    private bool isshooting;
    // Start is called before the first frame update
    void Start()
    {
        targeting = this.GetComponent<EnemyTargeting>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (targeting.target != null)
        {
            if (!isshooting)
            {
                StartCoroutine(Shoot());
                isshooting = true;
            }
            
        }
        else
        {
            isshooting = false;
        }
    }
    public  IEnumerator Shoot()
    {
        
        while (targeting.target != null)
        {
            
            GameObject spawnedbullet = Instantiate(Bullet, this.transform.position, Quaternion.identity);
            spawnedbullet.GetComponent<BulletTravel>().target = targeting.target;
            yield return new WaitForSeconds(shootcooldown);
        }

    }
}
