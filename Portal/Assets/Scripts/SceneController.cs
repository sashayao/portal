﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static bool isLoading = true;
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    //public void LoadGame()
    //{
    //    isLoading = true;
    //    SceneManager.LoadScene(1);
    //}
}
