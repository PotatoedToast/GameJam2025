using UnityEngine;

public class Objects : MonoBehaviour
{

    public Tools tool;
    public string toolNeeded;
    public bool canInteract = false;
    public bool isInteracted = false;
    public DialogueAsset success;
    public DialogueAsset failure;
    
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

    public bool Investigate(Tool tool, out string result) {
        if (tool != null && tool.toolName == toolNeeded) {
            // do stuff
            DialogueController.dialogues = success;
            DialogueController.i = 0;
        } else {
            // do other stuff
            DialogueController.dialogues = failure;
            DialogueController.i = 0;
        }
    }

}
