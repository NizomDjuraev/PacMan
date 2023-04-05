using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button restartButton;
    public Button mainMenuButton;
    public Button quitButton;

    public void OnEnable()
    {
        restartButton.onClick.AddListener(Restart);
        mainMenuButton.onClick.AddListener(MainMenu);
        quitButton.onClick.AddListener(Quit);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreDisplay.scoreValue = 0;
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Quit()
    {
        Application.Quit();
    }
}
