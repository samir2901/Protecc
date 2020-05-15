using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject gameOverPanel;

    public GameObject HUD;
    public GameObject spawnManger;   

    public void ShowGameOverScreen()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        HUD.SetActive(false);
        spawnManger.SetActive(false);
        GameObject.FindGameObjectWithTag("FamilyMember").SetActive(false);
        gameOverPanel.SetActive(true);
    }

    public void ShowWinScreen()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        HUD.SetActive(false);
        spawnManger.SetActive(false);
        GameObject.FindGameObjectWithTag("FamilyMember").SetActive(false);
        winPanel.SetActive(true);
    }
}
