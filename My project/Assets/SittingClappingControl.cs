using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SittingClappingControl : MonoBehaviour
{
    Animator animator;
    public int sittingAnimationTime;
    public int clappingAnimationTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //isLaughingHash = Animator.StringToHash("isLaughing");
        StartCoroutine(ClappingAnimation());
    }
   
    public IEnumerator ClappingAnimation(){
        while (true)
         {
            //Debug.Log("started" + Time.time);
            animator.SetBool("isSitting", false);
            animator.SetBool("isClapping", true);
            yield return new WaitForSeconds(sittingAnimationTime);
            //Debug.Log("finished" + Time.time);
            animator.SetBool("isSitting", true);
            animator.SetBool("isClapping", false);
            yield return new WaitForSeconds(clappingAnimationTime);
         }
    }
}
