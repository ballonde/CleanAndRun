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
        var randomObstacle = Random.Range(0, obstacles.Count);
        var randomSpawn = Random.Range(0, spawnPoints.Count);
        Instantiate(obstacles[randomObstacle], spawnPoints[randomSpawn].transform.position, Quaternion.identity);
    }
}
