using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Text_Canvas_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayScrollingTextCanvas() {
        if (gameObject.activeSelf) {
            gameObject.SetActive(false);
        } else {
            gameObject.SetActive(true);
        }
    }
}
