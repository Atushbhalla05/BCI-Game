using System.Collections; 
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    [SerializeField]  GameObject planet;
    [SerializeField] GameObject asteroidBelt;
    [SerializeField] float waitMin;
    [SerializeField] float waitMax;

    [SerializeField] float yMin;
    [SerializeField] float yMax;
    [SerializeField] float xValue;


    void Start()
    {
        StartCoroutine("SpawnPlanets");
        StartCoroutine("SpawnAsteroids");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPlanets()
    {
        while (true)
        {
            float waitTime = Random.Range(waitMin, waitMax);
            float yValue = Random.Range(yMin, yMax);
            Vector3 spawnPosition = new Vector3(xValue, yValue, -5);
            Instantiate(planet, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            float waitTime = Random.Range(waitMin, waitMax);
            Vector3 spawnPosition = new Vector3(xValue, 0, -4);
            Instantiate(asteroidBelt, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
