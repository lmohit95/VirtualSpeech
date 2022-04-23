using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_Button_Controller : MonoBehaviour
{
    public void displayNextButton() {
        gameObject.SetActive(true);
    }

    public void hideNextButton() {
        gameObject.SetActive(false);
    }
}
