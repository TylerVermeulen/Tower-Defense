using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Animations;
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
        CheckAnimation();
    }
    public void CheckAnimation()
    {
        if (pathing.Waypointindex == 2 || pathing.Waypointindex == 14)
        {
            animator.ResetTrigger("walkforward");
            animator.SetTrigger("walkright");
        }
        if (pathing.Waypointindex == 5 || pathing.Waypointindex == 17)
        {
            animator.ResetTrigger("walkright");
            animator.SetTrigger("walkbackward");
        }
        if (pathing.Waypointindex == 8 || pathing.Waypointindex == 20)
        {
            animator.ResetTrigger("walkbackward");
            animator.SetTrigger("walkleft");
        }
        if (pathing.Waypointindex == 11 || pathing.Waypointindex == 23)
        {
            animator.ResetTrigger("walkleft");
            animator.SetTrigger("walkforward");
        }
    }
}
