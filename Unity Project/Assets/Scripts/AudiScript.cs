using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiScript : CarScript{

    public override void Start()
    {
        base.Start();
    }

    public AudiScript()
    {
        lives = 3;
        speed = 0.2f;
    }

    public override void Movement()
    {
        base.Movement();
        position.x = Mathf.Clamp(transform.position.x, -4.4f, 4.4f);
        position.y = Mathf.Clamp(transform.position.y, -3.8f, 2.4f);
        position.z = 0;
        transform.position = position;
    }



}
