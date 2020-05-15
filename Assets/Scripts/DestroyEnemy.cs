using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject explosionFX;
    public int score = 0;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.collider != null)
                {
                    if (hit.collider.CompareTag("Enemy"))
                    {
                        Destroy(hit.collider.gameObject);
                        score += 10;
                        Instantiate(explosionFX, (Vector2)Camera.main.ScreenToWorldPoint(touch.position),Quaternion.Euler(new Vector3(-90,0,0)));
                        Debug.Log(score);
                    }
                }
            }
        }
    }
}
