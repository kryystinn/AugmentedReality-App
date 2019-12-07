using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JodyMoves : MonoBehaviour
{
    public GameObject jody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = jody.GetComponent<Animator>();
    }

    public void DoNothing()
    {
        animator.SetTrigger("doNothing");
    }

    public void LayDown()
    {
        animator.SetTrigger("layDown");
    }

    public void CircleCrunch()
    {
        animator.SetTrigger("circleCrunch");
    }

    public void BicycleCrunch()
    {
        animator.SetTrigger("bicycleCrunch");
    }

    public void WarmUp()
    {
        animator.SetTrigger("warmUp");
    }

    public void Energy()
    {
        animator.SetTrigger("energy");
    }
}
