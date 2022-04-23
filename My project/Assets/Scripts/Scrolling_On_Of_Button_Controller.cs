using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scrolling_On_Of_Button_Controller : MonoBehaviour
{
    public TextMeshProUGUI scrollingOnOffButtonText;
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void updateScrollingButtonText() {
        if (scrollingOnOffButtonText.text == "OFF") {
            scrollingOnOffButtonText.SetText("ON");    
        } else {
            scrollingOnOffButtonText.SetText("OFF");
        }
    }
}
