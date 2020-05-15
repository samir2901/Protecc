using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSometime : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 6);
    }
}
