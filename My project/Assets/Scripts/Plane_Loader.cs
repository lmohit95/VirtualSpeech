using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Loader : MonoBehaviour
{
    string speakingLevel = "beginner";

    void Start()
    {
        speakingLevel = PlayerPrefs.GetString("speakingLevel");
        Debug.Log("Speaking Level : " + speakingLevel);
    }

    void Update()
    {
        
    }
}
