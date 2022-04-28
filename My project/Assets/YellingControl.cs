using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellingControl : MonoBehaviour
{
   Animator animator;
    public int sittingAnimationTime;
    public int yellingAnimationTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(YellingAnimation());
    }
   
    public IEnumerator YellingAnimation(){
        while (true)
         {
            animator.SetBool("isSitting", false);
            animator.SetBool("isYelling", true);
            yield return new WaitForSeconds(sittingAnimationTime);
            animator.SetBool("isSitting", true);
            animator.SetBool("isYelling", false);
            yield return new WaitForSeconds(yellingAnimationTime);
         }
    }
}
