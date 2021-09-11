using UnityEngine;
using System.Collections;

public class VectorToEnemy : MonoBehaviour
{


    public GameObject enemy;
    Vector3 playerPos;
    Vector3 enemyPos;
    //float dist;
    float xDist;
    float yDist;
    float f;

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

        xDist = this.transform.position.x - enemy.transform.position.x;
        yDist = this.transform.position.y - enemy.transform.position.y;
    }

    void Update() 
    {
        Debug.Log(playerPos - enemyPos);
    }
    

    public Vector3 GetVectorToEnemy()
    {
       
            return playerPos - enemyPos;
        
        
    }

    /// <summary>
    /// Calculates the distance from the player to the enemy returned by GameManager.GetEnemyObject without using calls to magnitude.
    /// </summary>
    /// <see cref="GameController.GetEnemyObject"/>
    /// <returns>The scalar distance between the player and the enemy</returns>
    public float GetDistanceToEnemy()
    {
        return f = Mathf.Sqrt((xDist * xDist) + (yDist * yDist));
    }
    
}
