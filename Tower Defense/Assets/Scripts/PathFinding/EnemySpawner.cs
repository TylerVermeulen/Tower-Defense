using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject path;

    public void OnButtonClick(GameObject enemytype)
    {

            
        Instantiate(enemytype);
        enemytype.GetComponent<Pathing>().path = path;
            

    }
}
