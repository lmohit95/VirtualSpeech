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
        //isLaughingHash = Animator.StringToHash("isLaughing");
        StartCoroutine(YellingAnimation());
    }
   
    public IEnumerator YellingAnimation(){
        while (true)
         {
            Debug.Log("started" + Time.time);
            animator.SetBool("isSitting", false);
            animator.SetBool("isYelling", true);
            yield return new WaitForSeconds(sittingAnimationTime);
            Debug.Log("finished" + Time.time);
            animator.SetBool("isSitting", true);
            animator.SetBool("isYelling", false);
            yield return new WaitForSeconds(yellingAnimationTime);
         }
    }
}
