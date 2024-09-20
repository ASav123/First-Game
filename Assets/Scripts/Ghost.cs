using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //Speed varibles
    [HideInInspector]
    public float speedX;
    public float speedY;
    private Rigidbody2D myBody;
    private Transform player;
    public float speed = 2f;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    //Ghost movement
    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            myBody.velocity = direction * speed;
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") || collision.CompareTag("boundary"))
        {
            Destroy(gameObject);
        }if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().lives.lives--;
            Destroy(gameObject);
        }
       
    }


}
