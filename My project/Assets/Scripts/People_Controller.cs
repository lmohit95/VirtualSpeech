using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People_Controller : MonoBehaviour
{

    public GameObject people1;
    public GameObject people2;
    public GameObject people3;
    public GameObject people4;

    void Start() {
        /*people1 = GameObject.FindGameObjectWithTag("people1");
        people2 = GameObject.FindGameObjectWithTag("people2");
        people3 = GameObject.FindGameObjectWithTag("people3");
        people4 = GameObject.FindGameObjectWithTag("people4");*/
    }

    public void UpdatePeopleInScene(float numPeople) {
        Debug.Log(numPeople);
        if (numPeople >= 16f) {
            UpdatePeopleVisibility(true, true, true, true);        
        } else if (numPeople < 16f && numPeople >= 12f) {
            UpdatePeopleVisibility(true, true, true, false);        
        } else if (numPeople < 12f && numPeople >= 8f) {
            UpdatePeopleVisibility(true, true, false, false);        
        } else if (numPeople < 8f && numPeople >= 4f) {
            UpdatePeopleVisibility(true, false, false, false);        
        } else {
            UpdatePeopleVisibility(false, false, false, false);        
        }
    }

    public void UpdateAnimationValues(float animationValue) {
        Debug.Log(animationValue);
    }

    private void UpdatePeopleVisibility(
        bool arePeople1Visible, 
        bool arePeople2Visible, 
        bool arePeople3Visible, 
        bool arePeople4Visible) {
            people1.SetActive(arePeople1Visible);
            people2.SetActive(arePeople2Visible);
            people3.SetActive(arePeople3Visible);
            people4.SetActive(arePeople4Visible);
    }
}
