﻿using UnityEngine;
using System.Collections;

public class BombSpiral : MonoBehaviour
{
    public GameObject BombPrefab;
    [Range(5, 25)]
    public float SpiralAngleInDegrees = 10;
    public int BombCount = 10;
    public float StartRadius = 1;
    public float EndRadius = 3;
    
    



    /// <summary>
    /// Spawns spirals of BombPrefab game objects around the player. Create BombCount number of bombs 
    /// around the player, with each bomb being spaced SpiralAngleInDegrees apart from the next. The spiral 
    /// starts at StartRadius away from the player and ends at EndRadius away from the player.
    /// </summary>
    /// <returns>An array of the spawned bombs</returns>
    public GameObject[] SpawnBombSpiral()
    {
        float radius;
        float degrees = 0;
        Vector3 point;
        Vector3 playerPos;
        GameObject[] bombs = new GameObject[BombCount];
        playerPos = this.transform.position;
        radius = StartRadius;
        
        for (int i = 0; i < BombCount; i++)
        {
            point = (new Vector3(Mathf.Cos(degrees * Mathf.Deg2Rad), Mathf.Sin(degrees * Mathf.Deg2Rad))  * radius) + playerPos;
            
            radius += ((EndRadius-StartRadius)/BombCount);
            

            degrees += SpiralAngleInDegrees;

            GameObject spawnedBomb;
            spawnedBomb = Instantiate(BombPrefab, point, Quaternion.identity);
            bombs[i] = spawnedBomb;
        }
            return bombs;
    }

}
