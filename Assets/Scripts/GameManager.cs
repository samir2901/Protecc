using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject gameOverPanel;
    public GameObject mainCamera;
    public GameObject HUD;
    public GameObject spawnManger;
    public int currScore;
    GameObject[] enemies;
    private void Start()
    {        
        currScore = mainCamera.GetComponent<DestroyEnemy>().score;
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        currScore = mainCamera.GetComponent<DestroyEnemy>().score;
        if (currScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currScore);
        }
    }


    public void ShowGameOverScreen()
    {        
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
