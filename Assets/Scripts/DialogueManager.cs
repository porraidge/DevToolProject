using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    [Header("Name Space")]
    [Tooltip("Determines whether to show name header in dialogue box")]
    [SerializeField] bool showName;
    [SerializeField] GameObject characterName; //this is what we pull for the ui

    [Header("Icon")]
    [Tooltip("Determines whether to show icon box in dialogue box")]
    [SerializeField] bool showIcon;
    [SerializeField] GameObject characterIcon; //determines what shows up in the ui

    //method for assigning parameter into namespace
    public void AssignName()
    {
        //take a parameter and assign it as characterName
    }
    //method for assigning parameter into icon space
}
