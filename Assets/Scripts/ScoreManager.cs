using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Space]
    public int points;
    public TextMeshProUGUI figures;

    [Space]
    public GameObject GameOverScreen;
    public string SceneName;
    public GameObject TileManager;

    void Start()
    {
        points = 0;
        figures.text = "00";
        GameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        figures.text = points.ToString();
    }

    public void TryAgain()
    {
        points = 0;
        GotoScene(SceneName);
    }

    void GotoScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
