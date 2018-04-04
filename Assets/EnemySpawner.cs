using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;
    public float spawnInterval;
    float timer;
    // Use this for initialization
    void Start()
    {

    }

    public void spawnThing()
    {
        GameObject spawnedThing = Instantiate(myPrefab);
        spawnedThing.transform.position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawnThing();
            timer = spawnInterval;
        }
    }
}
