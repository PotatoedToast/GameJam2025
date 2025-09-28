using UnityEngine;

public class Objects : MonoBehaviour
{

    public Tools tool;
    public int toolNeeded;
    public bool canInteract = false;
    public bool isInteracted = false;
    public DialogueAsset d;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        canInteract = true;
    }

    private void OnTriggerExit(Collider other) {
        canInteract = false;
    }

}
