using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anjing : Enemy
{
    private void Update() {
        Move();
    }

    public override void Move(){
        base.Move();
        base.enemyRb.velocity = base.speed * Vector3.left;
    }
}
