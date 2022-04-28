using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughingControl : MonoBehaviour
{
    Animator animator;
    public int sittingAnimationTime;
    public int laughingAnimationTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(LaughingAnimation());
    }
   
    public IEnumerator LaughingAnimation(){
        while (true)
         {
            animator.SetBool("isSitting", false);
            animator.SetBool("isLaughing", true);
            yield return new WaitForSeconds(laughingAnimationTime);
            animator.SetBool("isSitting", true);
            animator.SetBool("isLaughing", false);
            yield return new WaitForSeconds(sittingAnimationTime);
         }
    }
}
