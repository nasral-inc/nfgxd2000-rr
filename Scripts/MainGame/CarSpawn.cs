using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public Settings settings;
    public GameObject Penis;
    public GameObject Shkoda;
    public GameObject Arbuz;
    public GameObject Printer;
    public GameObject Stiv;

    public GameObject Penis_orig;
    public GameObject Shkoda_orig;
    public GameObject Arbuz_orig;
    public GameObject Printer_orig;
    public GameObject Stiv_orig;
    
    void Start()
    {
        if (settings.MainPrefab == Penis_orig) {
            Instantiate(Penis, transform.position, transform.rotation);
        }
        else if (settings.MainPrefab == Arbuz_orig) {
            Instantiate(Arbuz, transform.position, transform.rotation);
        }
        else if (settings.MainPrefab == Printer_orig) {
            Instantiate(Printer, transform.position, transform.rotation);
        }
        else if (settings.MainPrefab == Shkoda_orig) {
            Instantiate(Shkoda, transform.position, transform.rotation);
        }
        else if (settings.MainPrefab == Stiv_orig) {
            Instantiate(Stiv, transform.position, transform.rotation);
        }
    }
}
