using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Dialogue_Button_Controller : MonoBehaviour
{
    public void HideStartPresentationButton() {
        gameObject.SetActive(false);
    }

    public void ShowStartPresentationButton() {
        gameObject.SetActive(true);
    }
}
