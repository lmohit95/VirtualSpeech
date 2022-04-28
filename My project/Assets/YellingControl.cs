using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellingControl : MonoBehaviour
{
//    Animator animator;
//     public int sittingAnimationTime;
//     public int yellingAnimationTime;

//     // Start is called before the first frame update
//     void Start()
//     {
//         animator = GetComponent<Animator>();
//         StartCoroutine(YellingAnimation());
//     }
   
//     public IEnumerator YellingAnimation(){
//         while (true)
//          {
//             animator.SetBool("isSitting", false);
//             animator.SetBool("isYelling", true);
//             yield return new WaitForSeconds(sittingAnimationTime);
//             animator.SetBool("isSitting", true);
//             animator.SetBool("isYelling", false);
//             yield return new WaitForSeconds(yellingAnimationTime);
//          }
//     }
    Animator animator;
    float blend = 0.0f;
    public float increase_by = 0.02f;
    public float decrease_by = 0.03f;
    //int blendHash;
    int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set reference for animator
        animator = GetComponent<Animator>();
        //blendHash = Animator.StringToHash("Blend");
    }
    void Update() {
            if (flag == 0){
                if (blend < 1.0f)
                {
                    blend += Time.deltaTime * increase_by;
                }
                if (blend >= 1.0f)
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
