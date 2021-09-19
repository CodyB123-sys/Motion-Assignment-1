using UnityEngine;
using System.Collections;

public class VisionCone : MonoBehaviour
{

    public float AngleSweepInDegrees = 60;
    public float ViewDistance = 3;
    Vector3 point1;
    Vector3 point2;
    Vector3 enemyPos;

    /// <summary>
    /// Calculates whether the player is inside the vision cone of an enemy as defined by the AngleSweepIndegrees
    /// and ViewDistance varilables. Do not use any magnitude or Distance methods.  You may use any of the previous
    /// methods you have written.
    /// </summary>
    /// <see cref="GameController"/>
    /// <returns>Whether the player is within the enemy's vision cone.</returns>
    /// 

    public bool IsPlayerInVisionCone()
    {
        point1 = (transform.up - (new Vector3(Mathf.Cos((AngleSweepInDegrees * 1/2) * Mathf.Deg2Rad), Mathf.Sin((AngleSweepInDegrees * 1/2) * Mathf.Deg2Rad)) * ViewDistance)) + enemyPos;
        point2 = (transform.up + (new Vector3(Mathf.Cos((AngleSweepInDegrees * 1/2) * Mathf.Deg2Rad), Mathf.Sin((AngleSweepInDegrees * 1/2) * Mathf.Deg2Rad)) * ViewDistance)) + enemyPos;

        enemyPos = this.transform.position;

        Debug.DrawLine(enemyPos, point1, Color.white, 100f);
        Debug.DrawLine(enemyPos, point2, Color.white, 100f);

        return false;
    }
    
}
