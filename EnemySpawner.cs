using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;
    [SerializeField]
    public float waitingForNextSpawn = 3f;
    public float theCountdown = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        theCountdown-= Time.deltaTime;
        if(theCountdown <= 0)
        {
            SpawnEnemy();
            theCountdown = waitingForNextSpawn;
        }
        
    }

    void SpawnEnemy()
    {
        float x = Random.Range (-9f, -8f);
        float y = Random.Range (4f, 4.33f);
        var newEnemy = Instantiate(EnemyPrefab, new Vector3(x,y,0), Quaternion.identity);
        newEnemy.active= true;
    }
}
