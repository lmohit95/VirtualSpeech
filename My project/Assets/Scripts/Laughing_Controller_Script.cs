using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laughing_Controller_Script : MonoBehaviour
{
    public Animator anim;
 
     void Start()
     {
         //StartCoroutine(PlayAnimation());
         //anim = GetComponent<Animator>();
         int i = 0;
         //while (i < 10) {
            Invoke("PlayAnimation", 6);
            Debug.Log("Start : " + i);
            i++;
         //}
     }

     public void PlayAnimation() {
         Debug.Log("Play Animation not null");
         if (anim != null) {
             Debug.Log("Play Animation : " + anim);
             Debug.Log("Here");
             anim.Play("Base Layer.Laughing State");
         }
     }
}
