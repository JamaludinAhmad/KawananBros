using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isDead = false;
    [SerializeField] public float speed;
    [SerializeField] public Rigidbody2D enemyRb;
    
    public virtual void Move(){
        //Do Nothing
    }

    public virtual void OnCollisionEnter2D(Collision2D other) {

        //ketika bertubruk dengan player
        if(other.gameObject.tag == "Player"){
            Debug.Log("Collision with " + other.gameObject.name);
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();

            //perkalian dot produk
            Vector2 playertoenemy = this.transform.position - player.transform.position;
            playertoenemy = playertoenemy.normalized;
            float dotresult = ((playertoenemy.x * Vector2.left.x) + (playertoenemy.y * Vector2.left.y) / (playertoenemy.sqrMagnitude * Vector2.left.sqrMagnitude));

            //enemy mati
            if(dotresult > -0.7f && dotresult < 0.7f){
                //player bouncing
                Rigidbody2D playerrb = player.GetComponent<Rigidbody2D>();
                playerrb.velocity = Vector2.up * 5;
                Destroy(this.gameObject);
                isDead = true;
            }
            else{
                Destroy(player.gameObject);
                GameManager.PlayerDead();
            }

            Debug.Log(dotresult);
        }

    }
}
