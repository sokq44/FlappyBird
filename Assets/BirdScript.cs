using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float flapStrangth;
    // Start is called before the first frame update
    void Start()
    {
        this.flapStrangth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rigidbody2D.velocity = Vector2.up * this.flapStrangth;
    }
}
