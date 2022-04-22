using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Previous_Button_Controller : MonoBehaviour
{
    public void ShowPreviousButton() {
        gameObject.SetActive(true);
    }

    public void HidePreviousButton() {
        gameObject.SetActive(false);
    }
}
