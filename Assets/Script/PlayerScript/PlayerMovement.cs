using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    Rigidbody2D rb ;
    Animator anim;
    // kecepatan dan daya lompat
    public float PlayerSpeed, PlayerJumpforce ,rightleft;
    //Cek diatas tanah atau tidak
    public Transform ground;
    public float radius;
    public  LayerMask whatisground;
    //untuk animasi
    private string jumpAnimation ="jump", idleAnimation = "idle", runAnimation = "run";



    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
        Jump();

        
    }
    private void FixedUpdate() {
          Move();

    }

    private void Move(){
        rightleft = Input.GetAxisRaw("Horizontal");

        

        
        rb.velocity = new Vector2(rightleft * PlayerSpeed, rb.velocity.y);

        if (rightleft != 0)
        {
            anim.SetTrigger(runAnimation);
            
        }
        else
        {
            anim.SetTrigger(idleAnimation);
        }
        if (rightleft > 0 ){
            transform.eulerAngles = Vector2.zero;

        }
        else if( rightleft < 0 ) {
            transform.eulerAngles = Vector2.up * 180;
         
           
        }
      
    }

    void Jump(){
        if ( Input.GetKeyDown(KeyCode.Space) && IsGrounded()  || Input.GetKeyDown(KeyCode.W) && IsGrounded() ){
            anim.SetTrigger(jumpAnimation);
            rb.velocity = Vector2.up * PlayerJumpforce;
        }
     
        }

         bool IsGrounded(){
            return Physics2D.OverlapCircle(ground.position, radius, whatisground);
            
        }
        private void OnDrawGizmos() {
            Gizmos.DrawWireSphere(ground.position,radius);
        }
    }


