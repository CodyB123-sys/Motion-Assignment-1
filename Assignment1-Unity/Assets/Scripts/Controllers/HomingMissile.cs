using UnityEngine;
using System.Collections;

public class HomingMissile : MonoBehaviour
{
    public float ForwardSpeed = 1;
    public float RotateSpeedInDeg = 45;
    Vector3 startingPos;

    GameObject enemy;
    GameObject player;

    // In Update, you should rotate and move the missile to rotate it towards the player.  It should move forward with ForwardSpeed and rotate at RotateSpeedInDeg.
    // Do not use the RotateTowards or LookAt methods.
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.Find("Player");

        startingPos = player.transform.up;

        Instantiate(this, startingPos, Quaternion.identity);
        
    }
}
