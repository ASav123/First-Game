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
    public bool deletable = false;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
    }

    //Ghost movement
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speedX, speedY);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet") || collision.CompareTag("boundary"))
        {
            Destroy(gameObject);
        }
    }


}
