using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public bool isplacingtower = false;

    public void OnButtonClick(GameObject towertype)
    {
        if (!isplacingtower)
        {

            Debug.Log("klik op menu");
            GameObject placedTower = Instantiate(towertype);
            Drag dscript = placedTower.GetComponent<Drag>();
            dscript.summontower = this;
            dscript.canPlace = true;
            isplacingtower = true;
            

        }
    }
}
