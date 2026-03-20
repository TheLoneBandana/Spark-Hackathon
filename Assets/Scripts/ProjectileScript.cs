using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    public bool isPlayerProjectile;
    //used in case we want enemies to have different levels of damage
    public int enemyDamage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(isPlayerProjectile && collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            //play animation
        }
        else if(!isPlayerProjectile && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().playerHealth -= enemyDamage;
            //play animation
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
