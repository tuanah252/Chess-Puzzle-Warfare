using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class spawner : MonoBehaviour
{
    
    public GameObject prefab;
    public GameObject core;
    public float spawnInterval = 3f;
    public int spawnCount = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnInterval, spawnInterval);
    }

    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(prefab, Random.insideUnitSphere * 10f, core.transform.rotation);
            Destroy(obj, 5f);
        }
    }
}