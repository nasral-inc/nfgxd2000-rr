using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    public GameObject PenisPrefab;
    void FixedUpdate()
    {
        float a = Random.Range(-1.0f, 1.0f);
        float b = Random.Range(-1.0f, 1.0f);
        Instantiate(PenisPrefab, new Vector3(transform.position.x+a, transform.position.y, transform.position.z+b), transform.rotation);
    }
}