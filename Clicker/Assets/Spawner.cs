using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CubePrefab;

    public float SpawnTime;
    void Start()
    {
        InvokeRepeating("SpawnCube", 0, SpawnTime);
    }

    
    void SpawnCube()
    {
        GameObject cobe = Instantiate(CubePrefab, transform.position, transform.rotation) as GameObject;
    }
}
