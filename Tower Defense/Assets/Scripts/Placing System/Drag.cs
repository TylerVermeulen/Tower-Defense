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
    private bool canPlace = false;
    private TowerSpawner towerSpawner;

    private Vector2 mousePosition;

    public bool CanPlace
    {
        get { return canPlace; }   
        set { canPlace = value; }
    }
    public TowerSpawner TowerSpawner 
    { 
        get { return towerSpawner; } 
        set {  towerSpawner = value; }
    }
    private void OnMouseDown()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hits = Physics2D.Raycast(mousePos,Vector3.forward, Mathf.Infinity,LayerMask.GetMask("Path"));
        if (hits)           
        {  
            if (hits.collider != null && hits.collider.name == "path" || hits.collider.name == "PlacedTower")
            { 
            }
        }
        else {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -0.5f);
            Suicide();
        }
    }

    public void Suicide()
    {
        this.gameObject.GetComponent<EnemyTargeting>().enabled = true;
        this.gameObject.GetComponent<ShootAtTarget>().enabled = true;
        towerSpawner.Isplacingtower = false;
        this.gameObject.layer = 6;
        this.enabled = false;
    }

    void Update()
    {
        if (towerSpawner.Isplacingtower)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -1f);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
