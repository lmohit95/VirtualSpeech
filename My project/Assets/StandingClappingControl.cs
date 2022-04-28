using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingClappingControl : MonoBehaviour
{
    Animator animator;
    public int sittingAnimationTime;
    public int clappingAnimationTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(ClappingAnimation());
    }
   
    public IEnumerator ClappingAnimation(){
        while (true)
         {
            animator.SetBool("isSitting", false);
            animator.SetBool("isClapping", true);
            yield return new WaitForSeconds(sittingAnimationTime);
            animator.SetBool("isSitting", true);
            animator.SetBool("isClapping", false);
            yield return new WaitForSeconds(clappingAnimationTime);
         }
    }
}
