using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int amountToSpawn;

    void Start()
    {
        
    }

    void Update()
    {   
        if(amountToSpawn > 0)
        {
            GameObject obj = Instantiate(enemyPrefab, transform.position, transform.rotation);
            //obj.GetComponent<EnemyBehaviour>().waypoints = waypoints
        }
    }
}
