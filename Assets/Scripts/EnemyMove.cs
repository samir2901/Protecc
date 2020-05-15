using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector2 memberPos;
    public float speed = 0.5f;
    public int damage = 1;
    public GameObject hurtFX;
    // Start is called before the first frame update
    void Start()
    {        
        memberPos = GameObject.FindGameObjectWithTag("FamilyMember").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, memberPos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("FamilyMember"))
        {
            collision.GetComponent<FamilyMember>().currentHealth -= damage;
            Instantiate(hurtFX, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
            Destroy(gameObject);
        }
    }

}
