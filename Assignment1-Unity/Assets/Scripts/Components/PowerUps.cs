using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour
{
    public GameObject PowerUpPrefab;
    public int PowerUpCount = 3;
    public float PowerUpRadius = 1;
    float degrees = 0;
    Vector3 point;
    Vector3 playerPos;

    /// <summary>
    /// Spawn a circle of PowerUpCount power up prefabs stored in PowerUpPrefab, evenly spaced, around the player with a radius of PowerUpRadius
    /// </summary>
    /// <returns>An array of the spawned power ups, in counter clockwise order.</returns>
    public GameObject[] SpawnPowerUps()
    {
        
        GameObject[] powerUps = new GameObject[PowerUpCount];
        playerPos = this.transform.position;

        for (int i = 0; i < PowerUpCount; i++)
        {
            point = (new Vector3(Mathf.Cos(degrees * Mathf.Deg2Rad), Mathf.Sin(degrees * Mathf.Deg2Rad)) * PowerUpRadius) + playerPos;
            GameObject spawnedPowerUp;
            spawnedPowerUp = Instantiate(PowerUpPrefab, point, Quaternion.identity);
            powerUps[i] = spawnedPowerUp;
            degrees += 120;
        }
            return powerUps;
    }
}
