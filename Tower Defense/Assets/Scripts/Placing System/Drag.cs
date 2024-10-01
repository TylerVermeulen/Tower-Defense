using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class Drag : MonoBehaviour 
{
    [SerializeField] private LayerMask pathLayer;

    private Transform Location;
    public bool canPlace = false;
    public TowerSpawner towerSpawner;

    private Vector2 mousePosition;
    private void Start()
    {     
    }
    private void OnMouseDown()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //mousePos, new Vector3(0, 0, 1), out RaycastHit hit, Mathf.Infinity, LayerMask.GetMask("Path")))
        RaycastHit2D hits = Physics2D.Raycast(mousePos,Vector3.forward, Mathf.Infinity,LayerMask.GetMask("Path"));
        RaycastHit2D hits2 = Physics2D.Raycast(mousePos, Vector3.forward, Mathf.Infinity, LayerMask.GetMask("T"));
        if (hits)           
        {
            Debug.Log("path");
            if (hits.collider != null && hits.collider.name == "path" || hits.collider.name == "PlacedTower")
            {
                Debug.Log("hit the path");
                
            }
        }
        else {
            Debug.Log("no path");
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.5f);
            Suicide();
        }

        if (canPlace && Input.mousePosition.x > 249f)
        {
                       

        }
    }

    public void Suicide()
    {
        towerSpawner.isplacingtower = false;
        this.gameObject.layer = 7;
        this.enabled = false;
      
    }

    void Update()
    {
        if (towerSpawner.isplacingtower)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -1f);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
