using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreLaughingControl : MonoBehaviour
{
    Animator animator;
    float blend = 0.0f;
    int blendHash;
    int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set reference for animator
        animator = GetComponent<Animator>();
        blendHash = Animator.StringToHash("Blend");
    }
    void Update() {
            if (flag == 0){
                if (blend < 1.0f)
                {
                    blend += Time.deltaTime * 0.02f;
                }
                if (blend >= 1.0f)
                {
                    flag = 1;
                }
                animator.SetFloat(blendHash, blend);
            }
            else{
                blend -= Time.deltaTime * 0.02f;
                if (blend <= 0.0f){
                    flag = 0;
                }
                animator.SetFloat(blendHash, blend);
            }
            
    }
    }