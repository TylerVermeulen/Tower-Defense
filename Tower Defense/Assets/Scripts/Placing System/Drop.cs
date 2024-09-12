using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject draggedholder;
    private GameObject draggedobject;
    // Start is called before the first frame update
    void Start()
    {
       // draggedholder = GameObject.Find("DraggedObjectHolder");
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (draggedholder.transform.childCount != 0)
        {
            draggedobject = draggedholder.transform.GetChild(0).gameObject;
        }
       
    }
    */
    private void OnMouseDown()
    {
      //  Debug.Log("hit dropzone");
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touched");
        if (collision.tag == "Tower")
        {
            Debug.Log("touched with tower");
            collision.transform.SetParent(this.transform);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Tower")
        {
            other.transform.SetParent(this.transform);
        }
    }
    */
}
