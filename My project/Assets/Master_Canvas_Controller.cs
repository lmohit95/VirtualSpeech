using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Master_Canvas_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMasterController() {
        gameObject.SetActive(true);
    }

    public void HideMasterController() {
        gameObject.SetActive(false);
    }

    public void loadLevelSelctionScene(int sceneIndex) {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}
