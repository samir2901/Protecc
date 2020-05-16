using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel, highScorePanel;
    public Text highScoreText;
    private GameManager gameManager;
    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }    

    private void Update()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void loadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowHighScore()
    {
        mainMenuPanel.SetActive(false);
        highScorePanel.SetActive(true);
    }

    public void showMainMenu()
    {
        mainMenuPanel.SetActive(true);
        highScorePanel.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
