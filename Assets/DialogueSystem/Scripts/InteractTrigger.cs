using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class InteractTrigger : MonoBehaviour
{
    //public Collider collider;
    //gui for trigger area
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }
}
