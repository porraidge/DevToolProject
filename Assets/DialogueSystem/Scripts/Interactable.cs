using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class Interactable : MonoBehaviour
{    
    [Tooltip("Player or object to activate interactable")]
    public GameObject toInteractWith;
    [Tooltip("Distance from interactable in order to allow interaction")]
    public float rangeToInteract = 5f;

    public Dialogue dialogue;

    private void Update()
    {   
        
        float distanceFromObject = 
            Vector3.Distance(toInteractWith.transform.position, transform.position);
        if(distanceFromObject <= rangeToInteract)
        {

            Debug.Log("Press E");
            //show something like 'press E' to say they can now interact --> needs
            // to disappear after they exit this range again.
            if(Input.GetKeyDown(KeyCode.E))
            {
            TriggerDialogue();
            }
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    //Gizmo to show interaction zone
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, rangeToInteract);
    }
}
