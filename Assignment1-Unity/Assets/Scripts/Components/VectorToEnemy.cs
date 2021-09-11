using UnityEngine;
using System.Collections;

public class VectorToEnemy : MonoBehaviour
{

    public GameObject enemy;
    Vector3 playerPos;
    Vector3 enemyPos;

    /// <summary>
    /// Calculated vector from the player to enemy found by GameManager.GetEnemyObject
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The vector from the player to the enemy.</returns>
    /// 

    void Start() 
    {
        playerPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        enemyPos = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
    }

    public Vector3 GetVectorToEnemy()
    {

        return Vector3.zero;
    }

    /// <summary>
    /// Calculates the distance from the player to the enemy returned by GameManager.GetEnemyObject without using calls to magnitude.
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The scalar distance between the player and the enemy</returns>
    public float GetDistanceToEnemy()
    {
        return 0;
    }
    
}
