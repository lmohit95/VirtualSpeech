using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Button_Controller : MonoBehaviour
{

    public Transform cameraTransform;
    public float forwardDistanceFromCamera = 3f;
    public float rightDistanceFromCamera = 1f;
    public float topDistanceFromCamera = 1f;
    public int x;
    public int y;
    public int z;

    void Update() {
        Vector3 resultingPosition = cameraTransform.position 
            + cameraTransform.forward * forwardDistanceFromCamera
            + cameraTransform.right * rightDistanceFromCamera
            + cameraTransform.up * topDistanceFromCamera;
        transform.position = resultingPosition;        
        transform.LookAt(cameraTransform);
        transform.Rotate(x, y, z);
    }
}
