using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour 
{
    private Transform Location;
    public bool canPlace = false;
    public GameObject draggedholder;
    public SummonTower summontower;
    private void OnMouseDown()
    {


        if (canPlace && Input.mousePosition.x > 249f)
        {

            Debug.Log("click op de toren");
                Suicide();           

        }
    }
    private void OnMouseUp()
    {

    }
    public void OnMouseDrag()
    {
        
    }
    
    public void Suicide()
    {
        summontower.isplacingtower = false; 
        this.enabled = false;
      
    }
    void Start()
    {

    }

    void Update()
    {
        if (summontower.isplacingtower/* && !hasbeenplaced*/)
        {
            
                //this.transform.parent = draggedholder.transform;
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
             
            
        }  
    }
}
