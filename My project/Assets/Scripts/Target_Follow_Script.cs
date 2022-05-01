using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Follow_Script : MonoBehaviour
{
    public Transform cameraTransform;
    public float forwardDistanceFromCamera = 1f;
    public float rightDistanceFromCamera = 1f;
    public float topDistanceFromCamera = 1f;
    public int x;
    public int y;
    public int z;

    void Update()
    {
        Vector3 resultingPosition = cameraTransform.position 
             + cameraTransform.forward * forwardDistanceFromCamera
             + cameraTransform.right * rightDistanceFromCamera
             + cameraTransform.up * topDistanceFromCamera;
        transform.position = resultingPosition;
        //Debug.Log(transform.position);
        // Need to bound position 
        //transform.LookAt(target);
        //transform.Rotate(x, y, z);
    }
}
