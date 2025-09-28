using System;
using UnityEngine;

public class Tools : MonoBehaviour
{   
    public DialogueController du;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        du.EndDialogue();
    }

    // Update is called once per frame

    public void useDNATest(string[] dialogue, string name) {
        string dna = "Let's use the DNA tester to check who this came from!";
        du.ShowDialogue(dna, name);
        // wait for space
        for (int i = 0; i < dialogue.Length; i++) {
            du.ShowDialogue(dialogue[i], name);
        }
        du.EndDialogue();
    }

    public void useFingerprintTest(string[] dialogue, string name) {
        string finger = "Let's use the fingerprint tester to see if anyone's traces were left behind...";
        du.ShowDialogue(finger, name);
        // wait for space
        for (int i = 0; i < dialogue.Length; i++) {
            du.ShowDialogue(dialogue[i], name);
        }
        du.EndDialogue();
    }

    public void useMetalDetector(string[] dialogue, string name) {
        string metal = "Let's use the metal detector to see if anything is inside!";
        du.ShowDialogue(metal, name);
        // change icon
        // wait for space
        for (int i = 0; i < dialogue.Length; i++) {
            du.ShowDialogue(dialogue[i], name);
        }
        du.EndDialogue();
    }

    public void useEyeGlasses(string[] dialogue, string name) {
        string glasses = "These contents are kind of hard to see, let me use my glasses to help.";
        du.ShowDialogue(glasses, name);
        // wait for space
        for (int i = 0; i < dialogue.Length; i++) {
            du.ShowDialogue(dialogue[i], name);
        }
        du.EndDialogue();
    }

}