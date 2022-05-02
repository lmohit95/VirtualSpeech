using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SittingControl : MonoBehaviour
{
    Animator animator;
    float blend = 0.0f;
    public float increase_by = 0.02f;
    public float decrease_by = 0.03f;
    int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        // set reference for animator
        animator = GetComponent<Animator>();
    }
    void Update() {
            float blendValue = animator.GetFloat("Blend");
            if (blendValue == 0.95f) {
                return;
            }
            if (flag == 0){
                if (blend < 0.6f)
                {
                    blend += Time.deltaTime * increase_by;
                }
                if (blend >= 0.6f)
                {
                    flag = 1;
                }
                animator.SetFloat("Blend", blend);
            }
            else{
                blend -= Time.deltaTime * decrease_by;
                if (blend <= 0.0f){
                    flag = 0;
                }
                animator.SetFloat("Blend", blend);
            }
            
    }
}
