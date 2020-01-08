using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DistanceTravelled : MonoBehaviour
{
    public float distanceTravelled;
    private Vector3 lastPosition;
    public float totalDistanceTraveled;
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        
        
        if (distanceTravelled > 5f)
        {
            totalDistanceTraveled += distanceTravelled;
            
            distanceTravelled = 0f;
            TriggerEncounter();
        }
        
    }

    private void TriggerEncounter()
    {
        float randomNum = Random.Range(0f, 100f);
        print(randomNum);
        print(randomNum + totalDistanceTraveled);
        if (randomNum + totalDistanceTraveled > 125f)
        {
            //This is where we want to move the player into the battle scene
            SceneManager.LoadScene("BattleMap");
            // SceneManager.MoveGameObjectToScene;
            print("Encounter");
        }
    }
}