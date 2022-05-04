using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Master_Canvas_Controller : MonoBehaviour
{
    private GameObject teleprompterCanvas;
    private GameObject loudnessDetectorObject;
    private GameObject loudnessDetectionCanvas;
    public Transform cameraTransform;
    public float forwardDistanceFromCamera = 3f;
    public float rightDistanceFromCamera = 1f;
    public float topDistanceFromCamera = 1f;
    public int x;
    public int y;
    public int z;

    void Start() {
        //transform.Rotate(x, y, z);
    }
    
    void Update() {
        // Vector3 resultingPosition = cameraTransform.position 
        //     + cameraTransform.forward * distanceFromCamera;
        // transform.position = resultingPosition;
        //transform.LookAt(cameraTransform);
        
        Vector3 resultingPosition = cameraTransform.position 
             + cameraTransform.forward * forwardDistanceFromCamera;
        transform.position = resultingPosition;        
        transform.LookAt(cameraTransform);
        transform.Rotate(x, y, z);
    }

    public void DisplayMasterController() {
        gameObject.SetActive(true);
    }

    public void HideMasterController() {
        gameObject.SetActive(false);
    }

    public void HideMasterControllerAndShowTeleprompterController() {        
        // Getting reference of teleprompter_on_off_button
        // TextMeshProUGUI teleprompterText 
        //     = GameObject.FindGameObjectWithTag("Teleprompter_On_Text").GetComponent<TextMeshProUGUI>();                        

        List<GameObject> objectsInScene = new List<GameObject>();
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]) {
            if (go.tag == "Teleprompter_Canvas") {
                teleprompterCanvas = go;
            } else if (go.tag == "Loudness_Detector_Object") {
                loudnessDetectorObject = go;
            } else if (go.tag == "LoudnessDetectionCanvas") {
                loudnessDetectionCanvas = go;
            }
        }   

        // // Hiding/Showing Teleprompter based on teleprompter_on_off_button
        // if (teleprompterText.text == "OFF") {
        //     teleprompterCanvas.SetActive(true);
        //     FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        // } else {
        //     teleprompterCanvas.SetActive(false);
        // }        

        // Display Loudness Detector
        Toggle toggle = GameObject.FindGameObjectWithTag("Scrolling_On_Off_Button").GetComponent<Toggle>();
        if (toggle.isOn) {
            teleprompterCanvas.SetActive(true);            
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        } else {
            teleprompterCanvas.SetActive(false);
        }

        // Hiding Master Controller
        gameObject.SetActive(false);
    }

    public void loadLevelSelctionScene(int sceneIndex) {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}
