using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject[] objectsToClick; // Assign objects (fridge, stove, etc.)
    public string[] dialogues; // Pre-set character narration
    private int dialogueIndex = 0;

    public GameObject[] journalNotes; // Journal notes that get unlocked

    void Start()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        if (dialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[dialogueIndex];
        }
    }

    public void OnObjectClicked(int objectIndex)
    {
        Debug.Log("Clicked: " + objectsToClick[objectIndex].name);
    
        // Advance the dialogue
        dialogueIndex++;
        ShowDialogue();

        // Unlock the corresponding journal note
        PlayerPrefs.SetInt("JournalNote_" + objectIndex, 1);  // Mark this note as unlocked
        PlayerPrefs.Save();  // Ensure data is saved
    }
}