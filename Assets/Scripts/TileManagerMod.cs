using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerMod : MonoBehaviour
{
    public int TileThreshold;
    public int GatesPassed;
    public TileManager original;
    private bool spawn;

    void Start() {
        spawn = false;
        original = gameObject.GetComponent<TileManager>();
        GatesPassed = 0;
        TileThreshold = (original.nbrOfTiles)/2;
    }
    void Update()
    {
        if(GatesPassed >= TileThreshold){
            spawn = true;
        }

        if(spawn == true)
        {
            for(int i = 0; i < TileThreshold; i++){
                Spawn();
            }
            
            GatesPassed = 0;
        }
    }

    void Spawn()
    {
        original.DeleteTile();
        original.SpawnTile(Random.Range(1, original.totalNumOfTiles));
        spawn = false;
    }
}
