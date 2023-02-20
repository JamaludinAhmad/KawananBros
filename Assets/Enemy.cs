using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D enemyRb;
    
        private void Update() {
        enemyRb.velocity = new Vector2(-speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {

        //ketika bertubruk dengan player
        if(other.gameObject.tag == "Player"){
            Debug.Log("Collision with " + other.gameObject.name);
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();

            //perkalian dot produk
            Vector2 playertoenemy = this.transform.position - player.transform.position;
            playertoenemy = playertoenemy.normalized;
            float dotresult = ((playertoenemy.x * Vector2.left.x) + (playertoenemy.y * Vector2.left.y) / (playertoenemy.sqrMagnitude * Vector2.left.sqrMagnitude));

            if(dotresult > -0.7f && dotresult < 0.7f){
                Destroy(this.gameObject);
            }
            else{
                Destroy(player.gameObject);
                GameManager.Dead();
            }

            Debug.Log(dotresult);
        }

    }
}
