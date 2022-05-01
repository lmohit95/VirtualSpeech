using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    //private Queue<string> sentences;
    private List<string> sentences;
    private int sentenceIndex = 0;
    public Text nameText;
    public Text dialogueText;

    void Start()
    {
        //sentences = new Queue<string>();
        //sentences = new List<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        Debug.Log("Starting conversation with: " + dialogue.name);
        sentences = new List<string>();
        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.sentences) {
            //sentences.Enqueue(sentence);
            sentences.Add(sentence);
        }
    }

    public void DisplayNextSentence() {        
        if (sentenceIndex + 1 >= sentences.Count) {
            EndDialogue();
            return;
        }
        sentenceIndex++;

        //string sentence = sentences.Dequeue();        
        string sentence = sentences[sentenceIndex];        
        dialogueText.text = sentence;
        Debug.Log("Sentence: " + sentence);        
    }

    public void DisplayPreviousSentence() {        
        if (sentenceIndex - 1 <= 0) {
            return;
        }
        sentenceIndex--;

        //string sentence = sentences.Dequeue();        
        string sentence = sentences[sentenceIndex];        
        dialogueText.text = sentence;
        Debug.Log("Sentence: " + sentence);
    }

    public void EndDialogue() {
        GameObject nextButton = GameObject.FindGameObjectWithTag("Next_Button");
        //nextButton.SetActive(false);
        Debug.Log("No more sentences");
    }

    public void HideTeleprompterController() {
        GameObject closeTeleprompter = GameObject.FindGameObjectWithTag("Close_Teleprompter_Button");
        closeTeleprompter.SetActive(false);
    }
}
