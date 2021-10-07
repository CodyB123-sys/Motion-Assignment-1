using UnityEngine;
using System.Collections;

public class VisionCone : MonoBehaviour
{

    public float AngleSweepInDegrees = 60;
    float degrees;
    public float ViewDistance = 3;
    Vector3 point1;
    Vector3 point2;
    Vector3 enemyPos;
    GameObject player;
    VectorToEnemy vectorToEnemyScript;

    /// <summary>
    /// Calculates whether the player is inside the vision cone of an enemy as defined by the AngleSweepIndegrees
    /// and ViewDistance varilables. Do not use any magnitude or Distance methods.  You may use any of the previous
    /// methods you have written.
    /// </summary>
    /// <see cref="GameController"/>
    /// <returns>Whether the player is within the enemy's vision cone.</returns>
    /// 

    void Start()
    {
        player = GameController.GetPlayerObject();
        vectorToEnemyScript = player.GetComponent<VectorToEnemy>();
    }

    public bool IsPlayerInVisionCone()
    {
        
        

        float enemyAngle = Mathf.Atan2(this.transform.up.y, this.transform.up.x) * Mathf.Rad2Deg;
        float enemyToPlayerAngle = Mathf.Atan2(-vectorToEnemyScript.GetVectorToEnemy().y, -vectorToEnemyScript.GetVectorToEnemy().x) * Mathf.Rad2Deg;
        point1 = (new Vector3(Mathf.Cos((enemyAngle + (AngleSweepInDegrees/2)) * Mathf.Deg2Rad), Mathf.Sin((enemyAngle + (AngleSweepInDegrees/2)) * Mathf.Deg2Rad)) * ViewDistance) + enemyPos;
        point2 = (new Vector3(Mathf.Cos((enemyAngle - (AngleSweepInDegrees/2)) * Mathf.Deg2Rad), Mathf.Sin((enemyAngle - (AngleSweepInDegrees/2)) * Mathf.Deg2Rad)) * ViewDistance) + enemyPos;


        

        //Debug.Log("this is enemy to player angle " + enemyToPlayerAngle);
        //Debug.Log("This is the enemy angle " + enemyAngle);
        //Debug.Log(vectorToEnemyScript.GetDistanceToEnemy());
        //Debug.Log("this is point1 " + point1);
        //Debug.DrawLine(enemyPos, point1, Color.white, 100f);
        //Debug.DrawLine(enemyPos, point2, Color.white, 100f);

        if (enemyToPlayerAngle >= (enemyAngle - (AngleSweepInDegrees/2)) && enemyToPlayerAngle <= (enemyAngle + (AngleSweepInDegrees/2)) && vectorToEnemyScript.GetDistanceToEnemy() <= ViewDistance)
        {
            //Debug.Log("Player is in cone");
            return true;
        }
        else {
            //Debug.Log("Player is not in cone");
            return false;
        }

        
    }
    
}
