﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FailedWindow : MonoBehaviour
{
    //private GameObject FailedReminder;
    //private PlayerHealth ph;
    void Start()
    {
        //FailedReminder = GameObject.Find("FailedPanel");
        //ph = GameObject.Find("PlayerUI").GetComponent<PlayerHealth>();

        /*Button exit_game = GameObject.Find("ExitGame").GetComponent<Button>();
        exit_game.onClick.AddListener(LoadMainMenuScene);
        Button restart_game = GameObject.Find("RestartGame").GetComponent<Button>();
        restart_game.onClick.AddListener(LoadMainScene);*/

        //ShowReminder();
    }

    private void FixedUpdate()
    {
        //if (ph.HealthEmpty()) { ShowReminder(); }
    }
    //private void HideReminder() { FailedReminder.SetActive(false); }
    //private void ShowReminder() { FailedReminder.SetActive(true); }
    public void LoadMainMenuScene() { SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single); }
    public void LoadMainScene() { SceneManager.LoadScene("MainSceneTest", LoadSceneMode.Single); /*HideReminder();*/ }
}
