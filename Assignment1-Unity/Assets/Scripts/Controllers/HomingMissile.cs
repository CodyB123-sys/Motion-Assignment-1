using UnityEngine;
using System.Collections;

public class HomingMissile : MonoBehaviour
{
    public float ForwardSpeed = 1;
    public float RotateSpeedInDeg = 45;
    Vector3 missileToEnemy;
    float missileToEnemyDot;
    

    // In Update, you should rotate and move the missile to rotate it towards the player.  It should move forward with ForwardSpeed and rotate at RotateSpeedInDeg.
    // Do not use the RotateTowards or LookAt methods.
    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
  
        Vector3 enemyPos;
        enemyPos = enemy.transform.position;

        missileToEnemy = enemyPos - this.transform.position;
        
        missileToEnemy = Vector3.Normalize(missileToEnemy);


        //Debug.DrawRay(this.transform.position, missileToEnemy, Color.white);
        //Debug.DrawRay(this.transform.position, this.transform.right, Color.white);

        
        missileToEnemyDot = Vector3.Dot(this.transform.right, missileToEnemy);

        Debug.Log(missileToEnemyDot);
        
        transform.Translate(Vector3.up * ForwardSpeed * Time.deltaTime);
        transform.Rotate(0, 0, (RotateSpeedInDeg * Time.deltaTime) * -missileToEnemyDot);
        
        
    }
}
