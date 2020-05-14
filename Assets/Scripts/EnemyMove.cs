using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector2 memberPos;
    public float speed = 0.5f;
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
}
