using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour 
{
    private Transform Location;
    public bool canPlace = false;
   
    public TowerSpawner summontower;
    private void OnMouseDown()
    {


        if (canPlace && Input.mousePosition.x > 249f)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.5f);
        
        Debug.Log("click op de toren");
                Suicide();           

        }
    }

    public void Suicide()
    {
        summontower.isplacingtower = false; 
        this.enabled = false;
      
    }

    void Update()
    {
        if (summontower.isplacingtower)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -1f);
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
