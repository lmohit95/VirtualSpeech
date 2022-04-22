using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleprompter_canvas_controller : MonoBehaviour
{
    public void ShowTeleprompterCanvas() {
        gameObject.SetActive(true);
    }

    public void HideTeleprompterCanvas() {
        gameObject.SetActive(false);
    }
}
