using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        this.logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            this.logic.AddScore(1);
    }
}
