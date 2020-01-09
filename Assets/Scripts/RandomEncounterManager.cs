using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomEncounterManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemiesArr;
    public Vector3[] enemyPosArray;
    // Start is called before the first frame updat
    void Start()
    {
        Instantiate(player, new Vector3(0, 1f, 0), Quaternion.identity);
        player.gameObject.GetComponent<DistanceTravelled>().inCombat = true;
        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnEnemies()
    {
        int enemiesSpawned = 0;
        for (int i = 0; i < enemiesArr.Length; i++)
        {
            var coinFlip = Random.Range(0, 2);

            if (coinFlip == 1)
            {
                var xpos = (i + 1) * 10f;
                Instantiate(enemiesArr[i], enemyPosArray[i], Quaternion.identity);
                enemiesSpawned++;
            }
        }
        // Check if spawned enemies are ZERO
        if(enemiesSpawned == 0) {
            print("NO ENEMIES SPAWNED, SPAWNING ONE NOW");
            Instantiate(enemiesArr[0], enemyPosArray[0], Quaternion.identity);
        }
    }
}
