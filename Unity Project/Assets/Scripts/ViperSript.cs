using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViperSript : CarScript {

    public override void Start()
    {
    }

    public ViperSript()
    {
        lives = 5;
        speed = 0.2f;
    }

    public override void Movement()
    {
        base.Movement();
        position.x = Mathf.Clamp(transform.position.x, -5.6f, 5.6f);
        position.y = Mathf.Clamp(transform.position.y, -3.8f, 2.4f);
        position.z = 0;
        transform.position = position;
    }
}
