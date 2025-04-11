using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
public class Spawn : MonoBehaviour
{ 
    public float jeda = 0.8f;   
    float timer;
    public GameObject[] asteroid;

    private float lastSpawnTime = 0f; 
    private float minSpawnInterval = 0.2f; 
    
    void Start()
    {
        
    }

   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int randomIndex = Random.Range(0, asteroid.Length);
            Vector3 spawnPosition = transform.position;

            
            if (Time.time - lastSpawnTime < minSpawnInterval)
            {
                return;
            }

            Instantiate(asteroid[randomIndex], spawnPosition, Quaternion.identity);
            lastSpawnTime = Time.time; 
            timer = 0;
        }
    }
}
