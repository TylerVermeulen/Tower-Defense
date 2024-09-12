using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour
{
    [SerializeField]private GameObject towerspawner;
    
    // Start is called before the first frame update
    void Start()
    {
        SummonTower ts = towerspawner.GetComponent<SummonTower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
