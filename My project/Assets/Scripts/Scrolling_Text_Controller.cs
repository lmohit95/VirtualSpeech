using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Text_Controller : MonoBehaviour
{

    public float scrollSpeed = 0.2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 tranformVector = transform.TransformDirection(0, 1, 0);
        currentPosition += tranformVector * scrollSpeed * Time.deltaTime;
        transform.position = currentPosition;        
    }

    public void DisplayScrollingText() {
        gameObject.SetActive(true);
    }
}
