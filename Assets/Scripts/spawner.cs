using UnityEngine;


public class spawner : MonoBehaviour
{
    
    public GameObject Person;                // The enemy prefab to be spawned.
    public static float spawnTime = 0;           // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


    void Start()
    {
        spawnTime = Random.Range(16f, 26f);
    // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
    InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        
       

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(Person, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}