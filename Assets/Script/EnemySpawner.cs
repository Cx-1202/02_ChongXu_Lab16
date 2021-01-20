using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject EnemyPrefab;
    public float spawnInterval;

    public float minX = -9.5f;
    public float maxX = 9.5f;
    public float minZ = -9.5f;
    public float maxZ = 9.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndSpawn(spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);

            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0.3f, Random.Range(minZ, maxZ));

            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
