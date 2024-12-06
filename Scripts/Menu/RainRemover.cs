using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainRemover : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
    }
}
