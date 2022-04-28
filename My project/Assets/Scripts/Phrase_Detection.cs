using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class Phrase_Detection : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start() {
        Debug.Log("Phrase Detection: Start");
        AddLightKeywords(keywords);
        AddAnimationKeywords(keywords);
        AddStandUpKeywords(keywords);
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    void AddAnimationKeywords(Dictionary<string, System.Action> keywords) {
        keywords.Add("hello everyone", SwitchToIdleState);
        keywords.Add("hi everyone", SwitchToIdleState);
    }

    void AddLightKeywords(Dictionary<string, System.Action> keywords) {
        keywords.Add("lights off", SwitchOffLights);
        keywords.Add("off the lights", SwitchOffLights);
        keywords.Add("lights on", SwitchOnLights);
        keywords.Add("on the lights", SwitchOnLights);
    }

    void AddStandUpKeywords(Dictionary<string, System.Action> keywords) {
        keywords.Add("stand up", StandUp);
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args) {
        Debug.Log("KeywordRecognizer_OnPhraseRecognized: text : " + args.text);
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction)) {
            keywordAction.Invoke();
        }
    }

    private void SwitchOffLights() {
       GameObject[] lights = GameObject.FindGameObjectsWithTag("Light");
       foreach (GameObject light in lights) {
           light.SetActive(false);
       }
    }

    private void SwitchOnLights() {       
       foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]) {
           if (go.tag == "Light") {
               go.SetActive(true);
           }
       }
    }

    // Some people can switch to idle state
    private void SwitchToIdleState() {

    }

    // ask 1 person to standup
    private void StandUp() {

    }
}

