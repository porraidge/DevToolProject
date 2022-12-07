using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    [Header("Name Space")]
    [Tooltip("Determines whether to show name header in dialogue box")]
    [SerializeField] bool showName;
    public Text nameText; //this is what we pull for the ui

    [Header("Icon")]
    [Tooltip("Determines whether to show icon box in dialogue box")]
    [SerializeField] bool showIcon;
    public Text dialogueText; //determines what shows up in the ui

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.characterName;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("end of conversation");
        //end the convo, turn off text boxes?
    }

    //method for assigning parameter into namespace
    public void AssignName()
    {
        //take a parameter and assign it as characterName
    }
    //method for assigning parameter into icon space
}
