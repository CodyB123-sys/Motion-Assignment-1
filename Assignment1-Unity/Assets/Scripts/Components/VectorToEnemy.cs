﻿using UnityEngine;
using System.Collections;

public class VectorToEnemy : MonoBehaviour
{


    
    Vector3 playerPos;
    Vector3 enemyPos;
    public Vector3 vectorToEnemy;
    float xDist;
    float yDist;
    float distance;

    /// <summary>
    /// Calculated vector from the player to enemy found by GameManager.GetEnemyObject
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The vector from the player to the enemy.</returns>
    /// 


    public Vector3 GetVectorToEnemy()
    {
        enemyPos = GameController.GetEnemyObject().transform.position;
        playerPos = this.transform.position; 
        
        //Debug.DrawLine(enemyPos, playerPos, Color.red, 2.5f);
        //Debug.Log(vectorToEnemy);

        
        
            return vectorToEnemy = enemyPos - playerPos;
        
        
    }

    /// <summary>
    /// Calculates the distance from the player to the enemy returned by GameManager.GetEnemyObject without using calls to magnitude.
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The scalar distance between the player and the enemy</returns>
    public float GetDistanceToEnemy()
    {
        enemyPos = GameController.GetEnemyObject().transform.position;
        playerPos = this.transform.position;

        xDist = enemyPos.x - playerPos.x;
        yDist = enemyPos.y - playerPos.y;

        distance = Mathf.Sqrt((xDist * xDist) + (yDist * yDist));
        //Debug.Log(distance);



        return distance;
        
    }
    
}
