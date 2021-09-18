using UnityEngine;
using System.Collections;

public class VectorToEnemy : MonoBehaviour
{


    public GameObject enemy;
    Vector3 playerPos;
    Vector3 enemyPos;
    Vector3 dist;
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
        enemyPos = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
        
        Debug.DrawLine(enemyPos, playerPos, Color.red, 2.5f);
        Debug.Log(dist);
        
            return dist = playerPos - enemyPos;
        
        
    }

    /// <summary>
    /// Calculates the distance from the player to the enemy returned by GameManager.GetEnemyObject without using calls to magnitude.
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The scalar distance between the player and the enemy</returns>
    public float GetDistanceToEnemy()
    {
        xDist = playerPos.x - enemyPos.x;
        yDist = playerPos.y - enemyPos.y;
        
        Debug.Log(distance);

        
        return distance = Mathf.Sqrt((xDist * xDist) + (yDist * yDist));
    }
    
}
