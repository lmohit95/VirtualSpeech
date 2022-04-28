using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingControl : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void UpdateAnimationValues(float animationValue) {
        Debug.Log(animationValue);
        if (animationValue >= 0 && animationValue <= 4){
            animator.SetBool("isSitting", true);
            animator.SetBool("isTalking", false);
            animator.SetBool("isMoreTalking", false);
        }
        if (animationValue > 4 && animationValue <= 7){
            animator.SetBool("isTalking", true);
            animator.SetBool("isSitting", false);
            animator.SetBool("isMoreTalking", false);
        }
        if (animationValue > 7 && animationValue <= 10){
            animator.SetBool("isMoreTalking", true);
            animator.SetBool("isSitting", false);
            animator.SetBool("isTalking", false);
        }
    }
}
