using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public Animator animator;
    private Pathing pathing;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        pathing = GetComponent<Pathing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pathing.waypointindex == 2 || pathing.waypointindex == 14)
        {
            animator.ResetTrigger("walkforward");
            animator.SetTrigger("walkright");
        }
        if (pathing.waypointindex == 5 || pathing.waypointindex == 17)
        {
            animator.ResetTrigger("walkright");
            animator.SetTrigger("walkbackward");
        }
        if (pathing.waypointindex == 8 || pathing.waypointindex == 20)
        {
            animator.ResetTrigger("walkbackward");
            animator.SetTrigger("walkleft");
        }
        if (pathing.waypointindex == 11 || pathing.waypointindex == 23)
        {
            animator.ResetTrigger("walkleft");
            animator.SetTrigger("walkforward");
        }
    }
}
