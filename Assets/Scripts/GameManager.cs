using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject gameOverPanel;

    public GameObject HUD;
    public GameObject spawnManger;

    private void Update()
    {
        
    }


    public void ShowGameOverScreen()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy.gameObject);
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
            Destroy(enemy.gameObject);
        }
        HUD.SetActive(false);
        spawnManger.SetActive(false);
        GameObject.FindGameObjectWithTag("FamilyMember").SetActive(false);
        winPanel.SetActive(true);
    }
}
