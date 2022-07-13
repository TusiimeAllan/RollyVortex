using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private GameObject Score, TouchToPlay, GameOverScreen, ScoreNarrative;

    public bool started = false;
    [SerializeField] private int sceneNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        LetsPause();
    }

    void Update()
    {
        if(Touchscreen.current != null)
        {
            Vector2 delta = Touchscreen.current.primaryTouch.delta.ReadValue();
            if(delta.x != 0.0)
            {
                LetsBegin();
            }
        }

        if(started == false)
        {
            LetsPause();
        }

        if(GameOverScreen.activeSelf == true)
        {
            Time.timeScale = 0;
            ScoreNarrative.SetActive(true);
        }
    }

    public void LetsBegin()
    {
        started = true;
        Time.timeScale = 1;
        Score.SetActive(true);
        TouchToPlay.SetActive(false);
        ScoreNarrative.SetActive(false);
    }

    public void LetsPause()
    {
        started = false;
        Time.timeScale = 0;
        Score.SetActive(false);
        TouchToPlay.SetActive(true);
    }

    public void GoHome()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
