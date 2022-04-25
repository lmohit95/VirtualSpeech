using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Follow_Script : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}
