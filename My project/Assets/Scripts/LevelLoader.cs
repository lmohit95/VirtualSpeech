using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    
    public GameObject loadingScreen;
    public Slider slider;
    public GameObject buttonSelectionCanvas;
    public TextMeshProUGUI progressText;

    void Start()
    {
        
    }

    public void LoadLevel(int sceneIndex) {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    private void updateUI() {
        loadingScreen.SetActive(true);
        buttonSelectionCanvas.SetActive(false);
    }

    IEnumerator LoadAsynchronously(int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        //updateUI();
    
        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            slider.value = progress;
            progressText.SetText(progress * 100f + "%");

            yield return null;
        }
    }

    void Update()
    {
        
    }
}
