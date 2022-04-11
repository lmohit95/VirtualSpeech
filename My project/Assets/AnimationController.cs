using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    //int isSittingHash;
    int isStandingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //isSittingHash = Animator.StringToHash("isSitting");
        isStandingHash = Animator.StringToHash("isStanding");
    }

    // Update is called once per frame
    void Update()
    {
        bool isStanding = animator.GetBool(isStandingHash);
        //bool sitPressed = Input.GetKey("w");
        bool standPressed = Input.GetKey("s");

        if (!isStanding && standPressed)
        {
            
            animator.SetBool(isStandingHash, true);
        }

        if (isStanding && !standPressed)
        {
            animator.SetBool(isStandingHash, false);
        }

        
    }
}
