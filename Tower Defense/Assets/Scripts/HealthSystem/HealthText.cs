using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthText : MonoBehaviour
{
    
    public int health;
    [SerializeField] TextMeshProUGUI healthtext;
    // Start is called before the first frame update
    void Start()
    {
        Pathing.onReachedEnd += LowerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Game Over Scene");
        }
    }
    public void LowerHealth(int damage)
    {
        healthtext.text = (health - damage) + " HP";
        health -= damage;
        Debug.Log(health);
    }
}
