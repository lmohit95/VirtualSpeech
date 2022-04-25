using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Master_Canvas_Controller : MonoBehaviour
{
    private GameObject teleprompterCanvas;
    public Transform cameraTransform;
    public float distanceFromCamera = 1f;
    
    void Update() {
        Vector3 resultingPosition = cameraTransform.position 
            + cameraTransform.forward * distanceFromCamera;
        transform.position = resultingPosition;
    }

    public void DisplayMasterController() {
        gameObject.SetActive(true);
    }

    public void HideMasterController() {
        gameObject.SetActive(false);
    }

    public void HideMasterControllerAndShowTeleprompterController() {        
        // Getting reference of teleprompter_on_off_button
        TextMeshProUGUI teleprompterText 
            = GameObject.FindGameObjectWithTag("Teleprompter_On_Text").GetComponent<TextMeshProUGUI>();
                    
        // Hiding Master Controller
        gameObject.SetActive(false);

        List<GameObject> objectsInScene = new List<GameObject>();
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]) {
            if (go.tag == "Teleprompter_Canvas") {
                teleprompterCanvas = go;
            }
        }   

        // Hiding/Showing Teleprompter based on teleprompter_on_off_button
        if (teleprompterText.text == "OFF") {
            teleprompterCanvas.SetActive(true);
        } else {
            teleprompterCanvas.SetActive(false);
        }        
    }

    public void loadLevelSelctionScene(int sceneIndex) {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}
