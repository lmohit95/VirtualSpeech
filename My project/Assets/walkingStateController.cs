using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingStateController : MonoBehaviour
{
    Animator animator;
    //int isSittingHash;
    int isWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //isSittingHash = Animator.StringToHash("isSitting");
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        //bool sitPressed = Input.GetKey("w");
        bool walkPressed = Input.GetKey("w");

        if (!isWalking && walkPressed)
        {
            
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !walkPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        
    }
}

