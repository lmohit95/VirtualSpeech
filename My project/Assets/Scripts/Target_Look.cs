using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Look : MonoBehaviour
{
    public Transform cameraTransform;
    void Update()
    {
        transform.LookAt(cameraTransform);
    }
}
