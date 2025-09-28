using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour {
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;
    public GameObject dialoguePanel;

    public static string[] dialogues = {"Hello, my name is Derry the Datypus! Welcome to Murder in the Meadow.",
                                        "To move, press WASD. To interact, press E. Go ahead and explore the room."};
    public static string name = "Derry the Datypus";
    public static int i = 0;
    public static boolean

    void Start() {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && i == 0) {
            ShowDialogue(dialogues[i], name);
            i++;
        } else if (Input.GetKeyDown(KeyCode.Space) && i > 0) {
            if (i < dialogues.Length) {
                ShowDialogue(dialogues[i], name);
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