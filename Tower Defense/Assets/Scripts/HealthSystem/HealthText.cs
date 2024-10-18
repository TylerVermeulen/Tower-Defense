using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthText : MonoBehaviour
{
    [SerializeField]private int health;
    [SerializeField]private TextMeshProUGUI healthtext;
    // Start is called before the first frame update
    void Start()
    {
        Pathing.onReachedEnd += LowerHealth;
    }
    // Update is called once per frame
    void Update()
    {
        CheckIfDead();
    }
    public void LowerHealth(int damage)
    {
        health -= damage;
        healthtext.text = health.ToString();
    }
    public void CheckIfDead()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
