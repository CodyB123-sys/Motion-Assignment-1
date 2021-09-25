using UnityEngine;
using System.Collections;

public class HomingMissile : MonoBehaviour
{
    public float ForwardSpeed = 1;
    public float RotateSpeedInDeg = 45;
    Vector3 enemyToPlayer;
    
    

    // In Update, you should rotate and move the missile to rotate it towards the player.  It should move forward with ForwardSpeed and rotate at RotateSpeedInDeg.
    // Do not use the RotateTowards or LookAt methods.
    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Vector3 enemyPos;
        enemyPos = transform.InverseTransformDirection(enemy.transform.position);

        Vector3 playerEnemy = Vector3.Scale(this.transform.position, enemyPos);

        //float angleCos = Mathf.Acos(playerEnemy);

        //enemyToPlayer = this.transform.position - enemyPos;
        
        
        
        /*if (this.transform.position.x > enemyPos.x && this.transform.position.y > enemyPos.y)
        {
            targetDir.x = this.transform.position.x - enemyPos.x;
            targetDir.y = this.transform.position.y - enemyPos.y;
        }
        else if (this.transform.position.x > enemyPos.x && this.transform.position.y > enemyPos.y)
        { 
            
        }*/

            

            float angle = Mathf.Atan2(this.transform.position.y - enemyPos.y, this.transform.position.x - enemyPos.x) * Mathf.Rad2Deg;
            

        
       
        transform.Translate(Vector3.up * ForwardSpeed * Time.deltaTime);
        transform.Rotate(0, angle, 0);
        
        
    }
}
