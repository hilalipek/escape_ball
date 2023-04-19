using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
       SpawnEnemy(waveNumber);
       Instantiate(powerupPrefab, new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9)),powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
       enemyCount = FindObjectsOfType<Enemy>(). Length; 
       if (enemyCount == 0)
       {
        waveNumber++;
        SpawnEnemy(waveNumber);
        Instantiate(powerupPrefab, new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9)), powerupPrefab.transform.rotation);
       }
    }
    void SpawnEnemy(int enemyNumber)
    {
        for (int i=0;i<enemyNumber;i++)
        {
        float spawnPosX = Random.Range(-9, 9);
        float spawnPosZ = Random.Range(-9, 9);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
        }
    }
}   
