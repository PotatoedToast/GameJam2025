using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactable : MonoBehaviour, IInteractable
{
    public void Interact(){
        Debug.Log("Interacted with " + gameObject.name);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}

