using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject spawnee;

    public bool stopSpawning = false;
    public float spawnTime;
    public float minSpawnDelay = 0.5f;
    public float maxSpawnDelay = 2f;
   
        void Start()
    {
       InvokeRepeating("SpawnObject", spawnTime, Random.Range(minSpawnDelay, maxSpawnDelay));
    }
    
    public void SpawnObject()
    {
    Instantiate(spawnee, transform.position, transform.rotation);
    if(stopSpawning)
    {
    CancelInvoke("SpawnObject");
    }
    }
}
