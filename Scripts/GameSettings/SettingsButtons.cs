using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtons : MonoBehaviour
{
    public Settings settings;

    public GameObject Penis;
    public GameObject Shkoda;
    public GameObject Arbuz;
    public GameObject Printer;
    public void PenisMobil() {
        settings.MainPrefab = Penis;
    }
    public void ShkodaMobil() {
        settings.MainPrefab = Shkoda;
    }
    public void ArbuzMobil() {
        settings.MainPrefab = Arbuz;
    }
    public void PrinterMobil() {
        settings.MainPrefab = Printer;
    }
}
