using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;  

public class MainMenu : MonoBehaviour
{
    // Linking buttons via the inspector
    public Button startButton;
    public Button settingsButton;
    public Button exitButton;

    void Start()
    {
        // I don't give a fuck
        startButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(OpenSettings);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Button function
    void StartGame()
    {
        // (Select Scene name)
        SceneManager.LoadScene("Scene1");
    }

    void OpenSettings()
    {
        // Open settings (we don't have this shit)
        Debug.Log("Settings");
    }

    void ExitGame()
    {
        // I need translate that?
        Debug.Log("Exit");
        Application.Quit();
    }
}
