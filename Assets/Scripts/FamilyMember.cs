using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FamilyMember : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.value = maxHealth;
    }

    private void Update()
    {
        //Debug.Log(currentHealth);
        healthBar.value = currentHealth;
    }
}
