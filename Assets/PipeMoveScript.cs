using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = -15f;

    void Update()
    {
        if(LogicScript.birdIsAlive)
        {
            transform.position = transform.position + (Vector3.left * this.moveSpeed) * Time.deltaTime;

            if (transform.position.x < this.deadZone)
                Destroy(gameObject);
        }
    }
}
