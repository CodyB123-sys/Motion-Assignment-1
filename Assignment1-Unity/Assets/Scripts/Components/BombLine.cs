using UnityEngine;
using System.Collections;

public class BombLine : MonoBehaviour
{

    public GameObject BombPrefab;
    public int BombCount;
    public float BombSpacing;

    

    /// <summary>
    /// Spawn a line of instantiated BombPrefabs behind the player ship. There should be BombCount bombs placed with BombSpacing amount of space between them.
    /// </summary>
    /// <returns>An array containing all the bomb objects</returns>
    public GameObject[] SpawnBombs()
    {
        GameObject[] bombs = new GameObject[BombCount];
        for (int i = 0; i < BombCount; i++)
        {
            GameObject spawnedBomb;
            spawnedBomb = Instantiate(BombPrefab, this.transform.position - (transform.up * ((i + 1) * BombSpacing)), Quaternion.identity);
            bombs[i] = spawnedBomb;
            //Debug.Log(bombs[i].name);
        }
        return bombs;
    }
    
}
