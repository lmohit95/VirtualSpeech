using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Expert_Button_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadPublicSpeakingScene() {
        PlayerPrefs.SetString("speakingLevel", "expert");
        PlayerPrefs.Save();
        SceneManager.LoadScene("PublicSpeakingScene");
    }
}
