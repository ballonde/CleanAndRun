using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public MusicManager musicManager;

    public List<GameObject> obstacles;
    public List<GameObject> spawnPoints;

    float chrono;
    float maxChrono;
    public float speed;

    int randomObstacle;
    int randomObstacleSave;
    int randomSpawn;
    int randomSpawnSave;

    // Start is called before the first frame update
    void Start()
    {
        maxChrono = musicManager.interval;
        chrono = maxChrono;

        speed = musicManager.selectedMusic.startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(maxChrono);
        if (chrono > 0)
        {
            chrono -= Time.deltaTime;
        }
        else
        {
            chrono = maxChrono;
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        randomObstacle = Random.Range(0, obstacles.Count);
        while (randomObstacle == randomObstacleSave)
        {
            randomObstacle = Random.Range(0, obstacles.Count);
        }
        randomObstacleSave = randomObstacle;

        randomSpawn = Random.Range(0, spawnPoints.Count);
        while (randomSpawn == randomSpawnSave)
        {
            randomSpawn = Random.Range(0, spawnPoints.Count);
        }
        randomSpawnSave = randomSpawn;

        Instantiate(obstacles[randomObstacle], spawnPoints[randomSpawn].transform.position, Quaternion.identity);
    }
}
