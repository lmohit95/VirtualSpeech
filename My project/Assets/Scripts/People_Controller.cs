using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People_Controller : MonoBehaviour
{
    public void UpdatePeopleInScene(float numPeople) {
        Debug.Log(numPeople);
        if (numPeople <= 10f) {
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }

    public void UpdateAnimationValues(float animationValue) {
        Debug.Log(animationValue);
    }
}
