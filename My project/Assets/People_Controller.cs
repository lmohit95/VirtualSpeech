using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePeopleInScene(float numPeople) {
        Debug.Log(numPeople);
        if (numPeople <= 10f) {
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }
}
