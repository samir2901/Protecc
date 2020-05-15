using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawners;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, spawners.Length);
        spawners[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        int prob = Random.Range(0, 3);
        if(prob == 0)
        {
            spawners[0].SetActive(true);
            spawners[1].SetActive(false);
            spawners[2].SetActive(false);
        }
        else if(prob == 1)
        {
            spawners[0].SetActive(false);
            spawners[1].SetActive(true);
            spawners[2].SetActive(false);
        }
        else 
        {
            spawners[0].SetActive(false);
            spawners[1].SetActive(false);
            spawners[2].SetActive(true);
        }

    }
}
