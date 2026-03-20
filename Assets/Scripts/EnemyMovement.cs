using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemyRB;
    public float enemySpeed = .05f;
    public float horizontalWidth = 5f;

    public GameObject bulletPrefab;
    public int shootDelay = 2;
    public int shootDamage = 1;

    private Vector2 shootDirection = Vector2.down;
    private float lifetime = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRB = gameObject.GetComponent<Rigidbody2D>();

        lifetime = 0;

        if (bulletPrefab != null)
        {
            StartCoroutine(Shoot());
        }
        
    }

    void FixedUpdate()
    {
        lifetime += enemySpeed * Time.fixedDeltaTime;

        enemyRB.linearVelocity = new Vector2(horizontalWidth * Mathf.Sin(lifetime), -lifetime);
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(shootDelay);
        GameObject bullet = Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
        bullet.GetComponent<Rigidbody2D>().linearVelocity = shootDirection;
        /*
        bulletScript = bullet.GetComponent<>();
        bulletScript.damage = shootDamage;
        bulletScript.isPlayer = false;
        */
    }
}
