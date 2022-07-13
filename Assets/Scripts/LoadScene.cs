﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private String SceneName;

    public void BringMe(){
        SceneManager.LoadScene(SceneName);
    }
}
