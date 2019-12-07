using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BryceMoves : MonoBehaviour
{
    public GameObject bryce;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = bryce.GetComponent<Animator>();
    }

    public void DoNothing()
    {
        animator.SetTrigger("doNothing");
    }

    public void Walking()
    {
        animator.SetTrigger("walk");
    }

    public void Runnning()
    {
        animator.SetTrigger("run");
    }

    public void Jogging()
    {
        animator.SetTrigger("jog");
    }

    public void JumpingJacks()
    {
        animator.SetTrigger("jumpingjacks");
    }

    public void NarutoRun()
    {
        animator.SetTrigger("narutoRun");
    }
}
