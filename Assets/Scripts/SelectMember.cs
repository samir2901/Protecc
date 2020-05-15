using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMember : MonoBehaviour
{
    public GameObject[] familyMembers;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, familyMembers.Length);
        familyMembers[index].SetActive(true);
    }
    
}
