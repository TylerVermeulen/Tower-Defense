using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonTower : MonoBehaviour
{
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    
     // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(int towertype)
    {
        //switch(buttontype)
        //{
        //    case 0:
        //        spawnlocation = button1.transform;
        //        break;
                
        //    case 1:
        //        spawnlocation = button2.transform;
        //        break;
        //    case 2:
        //        spawnlocation = button3.transform;
        //}
        

        switch (towertype)
        {
            case 0:
                Instantiate(tower1 /*button1.transform.position, Quaternion.identity*/);
                break;
            case 1: 
                Instantiate(tower2/*, button2.transform.position, Quaternion.identity*/); 
                break;
            case 2: 
                Instantiate(tower3/*, button3.transform.position, Quaternion.identity*/); 
                break;
        }
    }
}
