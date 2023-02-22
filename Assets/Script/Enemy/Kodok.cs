using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodok : Enemy
{
    private void Start() {
        Move();
    }
    public override void Move()
    {
        base.Move();
        StartCoroutine(Jump());
    }

    IEnumerator Jump(){
        while(!isDead){
            enemyRb.AddForce(new Vector2(-7,15) * 20);
            yield return new WaitForSeconds(4f);
        }
        
    }
}
