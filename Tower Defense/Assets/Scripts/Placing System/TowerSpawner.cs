using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    private bool isplacingtower = false;

    public bool Isplacingtower
    {
        get { return isplacingtower; }
        set { isplacingtower = value; }
        }
    public void OnButtonClick(GameObject towertype)
    {
        if (!isplacingtower)
        {
            GameObject placedTower = Instantiate(towertype);
            Drag dscript = placedTower.GetComponent<Drag>();
            dscript.TowerSpawner = this;
            dscript.CanPlace = true;
            isplacingtower = true;
        }
    }
}
