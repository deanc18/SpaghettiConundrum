using UnityEngine;
using UnityEngine.UI;

public class JournalManager : MonoBehaviour
{
    public GameObject[] journalNotes; // Assign these in Unity Inspector

    void Start()
    {
        for (int i = 0; i < journalNotes.Length; i++)
        {
            if (PlayerPrefs.GetInt("JournalNote_" + i, 0) == 1)  // Check if note is unlocked
            {
                journalNotes[i].SetActive(true);
            }
            else
            {
                journalNotes[i].SetActive(false);
            }
        }
    }
}