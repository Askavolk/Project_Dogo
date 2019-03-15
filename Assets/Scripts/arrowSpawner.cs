using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowSpawner : MonoBehaviour
{
    public GameObject arrow;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-0.4f, 0.4f);
            whereToSpawn = spawn.transform.position;
            Instantiate(arrow, whereToSpawn, Quaternion.identity);
            arrow.SetActive(true);


        }
        
    }
}
