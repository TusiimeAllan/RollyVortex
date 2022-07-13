using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            other.GetComponent<ScoreManager>().GameOverScreen.SetActive(true);
        }

    }
}