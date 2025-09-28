using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactable : MonoBehaviour, IInteractable
{

    private Color _originalColor; 
    private Renderer _renderer;

    private void Awake(){
        _renderer = GetComponent<Renderer>();
        if (_renderer != null){
            _originalColor = _renderer.material.color;
        }
    }

    public void Interact(){
        Debug.Log("Interacted with " + gameObject.name);
    }

    public void Highlight(bool isHighlighted){
        if (_renderer != null){
            if (isHighlighted){
                float tintAmount = 0.1f; // Adjust this value (0.0 to 1.0)
                _renderer.material.color = Color.Lerp(_originalColor, Color.white, tintAmount);
            } else {
                _renderer.material.color = _originalColor; // Default color
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}

