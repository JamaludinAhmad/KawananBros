using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Enemy
{
    [SerializeField] GameObject bulletObj;
    private void Start() {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot(){
        while(!isDead){
            GameObject newBullet = Instantiate(bulletObj, bulletObj.transform.position, Quaternion.identity);
            newBullet.SetActive(true);
            newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.left * 5;
            yield return new WaitForSeconds(3f);
        }
    }
}
