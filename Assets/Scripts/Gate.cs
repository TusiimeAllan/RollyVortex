using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private int LocalPoints;    

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            LocalPoints = other.GetComponent<ScoreManager>().points++;
            other.GetComponent<ScoreManager>().TileManager.GetComponent<TileManagerMod>().GatesPassed++;
        }

    }
}