using TMPro;
using System.Collections;
using UnityEngine;

public class DialogueUpdate : MonoBehaviour
{

    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;
    public GameObject dialoguePanel;

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

    public void CycleDialogue(string[] dialogue, string name) {
        
    }

    public IEnumerator WaitForSpace() {
        while (true) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                yield break;
            }
            yield return null;
        }
    }
}
