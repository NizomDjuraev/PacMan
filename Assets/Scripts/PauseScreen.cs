using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseScreen : MonoBehaviour
{
    public Button resumeButton;
    public Button mainMenuButton;
    public Button quitButton;
    public GameObject pausePanel;

    private bool isPaused = false;

    public void PauseGame()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        pausePanel.SetActive(isPaused);
    }

    void Start()
    {
        resumeButton.onClick.AddListener(Resume);
        mainMenuButton.onClick.AddListener(MainMenu);
        quitButton.onClick.AddListener(Quit);
        pausePanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
        pausePanel.gameObject.SetActive(true);
    }

    void Resume()
    {
        Time.timeScale = 1;
        pausePanel.gameObject.SetActive(false);
    }

    void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }


}
