﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || OVRInput.Get(OVRInput.Button.One))
            SceneManager.LoadScene("Game");

        if (Input.GetKeyDown(KeyCode.Escape) || OVRInput.Get(OVRInput.Button.Two))
            Application.Quit();
    }
}
