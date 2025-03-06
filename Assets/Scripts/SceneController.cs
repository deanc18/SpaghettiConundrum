using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadCharacterScene(int characterIndex)
    {
        PlayerPrefs.SetInt("CurrentCharacter", characterIndex); // Store which character is selected
        SceneManager.LoadScene("LevelScene");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}