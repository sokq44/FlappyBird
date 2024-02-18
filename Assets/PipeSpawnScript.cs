using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 5;

    public GameObject pipe;

    void Start()
    {
        spawnPipes();
    }

    void Update()
    {
        if (this.timer < spawnRate)
        {
            this.timer += Time.deltaTime;
        }
        else
        {
            spawnPipes();
            this.timer = 0;
        }
    }

    void spawnPipes()
    {
        if(LogicScript.birdIsAlive)
        {
            float lowestPoint = transform.position.y - this.heightOffset;
            float highestPoint = transform.position.y + this.heightOffset;

            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
        }
    }
}
