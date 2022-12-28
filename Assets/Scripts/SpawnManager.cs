using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public GameObject[] obstaclePrefab;
    private float startDelay = 2;
    private float reportRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, reportRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[index], spawnPos, obstaclePrefab[index].transform.rotation);
        }  
    }
}
