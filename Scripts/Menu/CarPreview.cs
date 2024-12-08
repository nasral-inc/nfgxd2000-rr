using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CarPreview : MonoBehaviour
{
    public Settings settings;
    private GameObject prefab;
    //private GameObject previewInstance;
    private GameObject instance;

    void Spawn() {
        prefab = settings.MainPrefab;
        // previewInstance = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
        // previewInstance.transform.SetParent(transform);
        // previewInstance.transform.localPosition = Vector3.zero;
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
        // prefab = settings.MainPrefab;
        // previewInstance = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
        // previewInstance.transform.SetParent(transform);
        // previewInstance.transform.localPosition = Vector3.zero;
        // Rigidbody rigidBody = previewInstance.GetComponent<Rigidbody>();
        // BoxCollider boxCollider = previewInstance.GetComponent<BoxCollider>();
        // Destroy(rigidBody);
        // Destroy(boxCollider);
    }
    void FixedUpdate() {
        instance.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z+1);

        if (settings.MainPrefab != prefab) {
            Destroy(instance);
            Spawn();
        }
    }
}
