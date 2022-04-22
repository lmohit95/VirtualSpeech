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
        sentences = new List<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        Debug.Log("Starting conversation with: " + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences) {
            //sentences.Enqueue(sentence);
            sentences.Add(sentence);
        }
    }

    public void DisplayNextSentence() {
        sentenceIndex++;
        if (sentenceIndex >= sentences.Count) {
            EndDialogue();
            return;
        }

        //string sentence = sentences.Dequeue();        
        string sentence = sentences[sentenceIndex];        
        dialogueText.text = sentence;
        Debug.Log("Sentence: " + sentence);        
    }

    public void DisplayPreviousSentence() {
        sentenceIndex--;
        if (sentenceIndex <= 0) {
            return;
        }

        //string sentence = sentences.Dequeue();        
        string sentence = sentences[sentenceIndex];        
        dialogueText.text = sentence;
        Debug.Log("Sentence: " + sentence);
    }

    public void EndDialogue() {
        GameObject nextButton = GameObject.FindGameObjectWithTag("Next_Button");
        nextButton.SetActive(false);
        Debug.Log("No more sentences");
    }
}
