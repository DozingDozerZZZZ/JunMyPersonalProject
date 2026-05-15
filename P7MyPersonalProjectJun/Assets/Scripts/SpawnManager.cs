using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    private Vector3 spawnPos = new Vector3(25, 0, -1);

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay,repeatRate);
        playerControllerScript=GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(0, obstacles.Length);
        if (playerControllerScript.gameOver == false)
        {
            
            Instantiate(obstacles[obstacleIndex], spawnPos, obstacles[obstacleIndex].transform.rotation);
        }
    }

    
}
