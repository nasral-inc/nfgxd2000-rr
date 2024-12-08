using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CarPreview : MonoBehaviour
{
    public Settings settings;
    private GameObject prefab;
    private GameObject instance;

    void Spawn() {
        prefab = settings.MainPrefab;
        instance = Instantiate(prefab, transform);
        instance.transform.localPosition = Vector3.zero;
        Rigidbody rigidBody = instance.GetComponent<Rigidbody>();
        BoxCollider boxCollider = instance.GetComponent<BoxCollider>();
        Destroy(rigidBody);
        Destroy(boxCollider);
    }
    void Start()
    {
        Spawn();
    }
    void FixedUpdate() {
        instance.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z+1);

        if (settings.MainPrefab != prefab) {
            Destroy(instance);
            Spawn();
        }
    }
}
