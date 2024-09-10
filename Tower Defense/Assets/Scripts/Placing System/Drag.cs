using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour 
{
    private Transform Location;
    private bool isdragging;

    private void OnMouseDown()
    {
        if (isdragging == true)
        {
            isdragging = false;
        }
        else if (isdragging == false)
        {
            isdragging = true;
        }
        
    }
    private void OnMouseUp()
    {
        if (transform.parent == null)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnMouseDrag()
    {
        
    }
    

    void Awake()
    {
        isdragging = true;
    }

    void Update()
    {
        if (isdragging == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }  
    }
}
