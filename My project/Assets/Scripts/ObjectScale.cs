using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale : MonoBehaviour {
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;
    public float loudnessSensibility = 1000;
    public float threshold = 0.1f;

    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        if (loudness < threshold) {
            loudness = 0;
        }

        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
    }

    public void ShowHideObject(bool showObject) {
        gameObject.SetActive(showObject);
    }
}

