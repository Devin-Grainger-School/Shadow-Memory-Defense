using UnityEngine;

public class MonsterSpwaner : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = -.4f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnRandomMonster()
    {
        //Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 15, spawnRangeZ);
        int monsterIndex = Random.Range(0, MonsterPrefabs.Length);
        Instantiate(MonsterPrefabs[monsterIndex], spawnPos, MonsterPrefabs[monsterIndex].transform.rotation);
    }
}