using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public const float MAX_FLY_DISTANCE = 10F;

    public Sprite playerProjSprite; 
    public Sprite enemyProjSprite;

    public bool isPlayerProjectile;
    //used in case we want enemies to have different levels of damage
    public int enemyDamage;
    public float speed;
    public float currentFlyDistance;

    private Rigidbody2D projRB;

    private void Awake()
    {
        projRB = gameObject.GetComponent<Rigidbody2D>();
    }

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
        UpdateFlyDistance();
    }

    private void UpdateFlyDistance()
    {
        currentFlyDistance += UnityEngine.Time.deltaTime * speed;
        if(currentFlyDistance >= MAX_FLY_DISTANCE)
        {
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }

    public void initializeProj(int damage, bool isPlayerProj, Vector2 direction, float speed)
    {
        enemyDamage = damage;
        isPlayerProjectile = isPlayerProj;
        projRB.linearVelocity = speed * direction;
        this.speed = speed;

        gameObject.GetComponent<SpriteRenderer>().sprite = isPlayerProjectile ? playerProjSprite : enemyProjSprite;
    }
}
