using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasperMoves : MonoBehaviour
{
    public GameObject jasper;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = jasper.GetComponent<Animator>();
    }

    public void DoNothing()
    {
        animator.SetTrigger("doNothing");
    }

    public void ClassicDance()
    {
        animator.SetTrigger("classic");
    }

    public void HipHopDance()
    {
        animator.SetTrigger("hiphop");
    }

    public void HouseDance()
    {
        animator.SetTrigger("house");
    }

    public void ThrillerDance()
    {
        animator.SetTrigger("thriller");
    }

    public void ShuffleDance()
    {
        animator.SetTrigger("shuffle");
    }
}

