using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    CircleCollider2D col;
    [SerializeField] PlayerMovement player;
    [SerializeField] LayerMask playermask;

    private void Start() {
        col = GetComponent<CircleCollider2D>();
    }

    
}
