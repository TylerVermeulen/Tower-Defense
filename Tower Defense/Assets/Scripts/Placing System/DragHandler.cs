using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour
{
    [SerializeField]private GameObject towerspawner;
    
    // Start is called before the first frame update
    void Start()
    {
        TowerSpawner ts = towerspawner.GetComponent<TowerSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
