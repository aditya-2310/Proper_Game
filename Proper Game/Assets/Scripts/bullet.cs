using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float speed = 10f;
    public Rigidbody2D rb;
    private int damage = 30;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        enemy Enemy = hitinfo.GetComponent<enemy>();
        if (Enemy != null)
        {
            Enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
