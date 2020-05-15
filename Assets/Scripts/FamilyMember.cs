using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyMember : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    private void Update()
    {
        //Debug.Log(currentHealth);
        if(currentHealth <= 0)
        {
            gameManager.ShowGameOverScreen();
        }
        healthBar.setHealth(currentHealth);
    }
}
