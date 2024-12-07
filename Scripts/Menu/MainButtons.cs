using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject MenuPanel;
    public void Play() {
        SceneManager.LoadScene(1);
    }
    public void Settings() {
        MenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    public void Exit() {
        Application.Quit();
    }

    public void SettingsApply() {
        SceneManager.LoadScene(0);
    }
}
