using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel, highScorePanel;
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
}
