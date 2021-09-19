using UnityEngine;
using System.Collections;

public class HomingMissile : MonoBehaviour
{
    public float ForwardSpeed = 1;
    public float RotateSpeedInDeg = 45;
    
    

    // In Update, you should rotate and move the missile to rotate it towards the player.  It should move forward with ForwardSpeed and rotate at RotateSpeedInDeg.
    // Do not use the RotateTowards or LookAt methods.
    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Vector3 enemyPos;
        enemyPos = enemy.transform.position;
        Vector3 targetDir = enemyPos - this.transform.position;
        
        
        
        
        /*if (this.transform.position.x > enemyPos.x && this.transform.position.y > enemyPos.y)
        {
            targetDir.x = this.transform.position.x - enemyPos.x;
            targetDir.y = this.transform.position.y - enemyPos.y;
        }
        else if (this.transform.position.x > enemyPos.x && this.transform.position.y > enemyPos.y)
        { 
            
        }*/

            float angle = Vector3.Angle(targetDir, Vector3.up);

        
       
        transform.Translate(Vector3.up * ForwardSpeed * Time.deltaTime);
        transform.Rotate(0, angle, 0);
        
        
    }
}
