using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength;
    
    public Rigidbody2D rigidbody2D;
    public LogicScript logic;

    void Start()
    {
        this.flapStrength = 5;
        LogicScript.birdIsAlive = true;

        this.logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    void Update()
    {
        if (LogicScript.birdIsAlive && Input.GetKeyDown(KeyCode.Space))
            this.rigidbody2D.velocity = Vector2.up * this.flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.logic.gameOver();
        LogicScript.birdIsAlive = false;
    }
}
