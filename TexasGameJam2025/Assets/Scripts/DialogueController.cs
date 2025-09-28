using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour {
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;
    public GameObject dialoguePanel;

    public static string[] dialogues = {};
    public static int i = 0;

    void Start() {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && i == 0) {
            ShowDialogue(dialogues[i], "Cathy Du");
            i++;
        } else if (Input.GetKeyDown(KeyCode.Space) && i > 0) {
            if (i < dialogues.Length) {
                ShowDialogue(dialogues[i], "Cathy Du");
                i++;
            } else {
                EndDialogue();
                i = 0;
            }
        }
    }

    public void ShowDialogue(string dialogue, string name)
    {
        nameText.text = name + ":";
        dialogueText.text = dialogue;
        dialoguePanel.SetActive(true);
    }

    public void EndDialogue()
    {
        nameText.text = null;
        dialogueText.text = null;
        dialoguePanel.SetActive(false);
    }
}