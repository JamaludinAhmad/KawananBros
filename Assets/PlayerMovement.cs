using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb ;
    // kecepatan dan daya lompat
    public float PlayerSpeed, PlayerJumpforce ,rightleft;
    //Cek diatas tanah atau tidak
    [SerializeField] private bool IsGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        
    }

    private void Move(){
        rightleft = Input.GetAxisRaw("Horizontal");

        
        rb.velocity = new Vector2(rightleft * PlayerSpeed, rb.velocity.y);
        if (rightleft > 0 ){
            transform.eulerAngles = Vector2.zero;
            
        }
        else if( rightleft < 0 ) {
            transform.eulerAngles = Vector2.up * 180;
           
        }
    }

    void Jump(){
        if ( Input.GetKeyDown(KeyCode.Space)  || Input.GetKeyDown(KeyCode.W) ){
            rb.velocity = Vector2.up * PlayerJumpforce;
        }
     
        }
    }

