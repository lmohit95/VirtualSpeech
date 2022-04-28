using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughingControl : MonoBehaviour
{
    Animator animator;
    public int sittingAnimationTime;
    public int laughingAnimationTime;
    //public int moreLaughingAnimationTime;
    //private float globalAnimationValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(LaughingAnimation());
    }

    // public void UpdateAnimationValues(float animationValue) {
    //     Debug.Log(animationValue);
    //     globalAnimationValue = animationValue;
    // }
   
    public IEnumerator LaughingAnimation(){
        while (true)
         {
            // if (globalAnimationValue < 3f){
            //     //while(globalAnimationValue < 3f){
            //         Debug.Log("started" + Time.time);
            //         animator.SetBool("isSitting", true);
            //         animator.SetBool("isLaughing", false);
            //         animator.SetBool("isMoreLaughing", false);
            //     //}
            // }
            // else if(globalAnimationValue >= 3f && globalAnimationValue < 8f){
            //     //while(globalAnimationValue >= 3f && globalAnimationValue < 8f){
            //         Debug.Log("Ended one:" + Time.time);
            //         Debug.Log("Started second:" + Time.time);
            //         animator.SetBool("isSitting", false);
            //         animator.SetBool("isMoreLaughing", false);
            //         animator.SetBool("isLaughing", true);
            //         yield return new WaitForSeconds(laughingAnimationTime);
            //         animator.SetBool("isSitting", true);
            //         animator.SetBool("isLaughing", false);
            //         animator.SetBool("isMoreLaughing", false);
            //         yield return new WaitForSeconds(sittingAnimationTime);
            //     //}
                
            // }
            // else if(globalAnimationValue >= 8f){
            //     //while(globalAnimationValue >= 8f){
            //         Debug.Log("Ended second:" + Time.time);
            //         Debug.Log("started third" + Time.time);
            //         animator.SetBool("isSitting", false);
            //         animator.SetBool("isLaughing", false);
            //         animator.SetBool("isMoreLaughing", true);
            //         yield return new WaitForSeconds(moreLaughingAnimationTime);
            //         animator.SetBool("isSitting", true);
            //         animator.SetBool("isLaughing", false);
            //         animator.SetBool("isMoreLaughing", false);
            //         yield return new WaitForSeconds(sittingAnimationTime);
            //     //}
            // }
            animator.SetBool("isSitting", false);
            animator.SetBool("isLaughing", true);
            yield return new WaitForSeconds(laughingAnimationTime);
            animator.SetBool("isSitting", true);
            animator.SetBool("isLaughing", false);
            yield return new WaitForSeconds(sittingAnimationTime);
         }
    }
}
