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
    public AudioSource audio;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }


    //Ghost movement
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speedX, speedY);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.CompareTag("Bullet"))
        {
            audio.Play();
            Debug.Log("audio played");

            Destroy(gameObject);
        }
        if (collision.CompareTag("boundary")) 
        {
            Destroy(gameObject);
        }
       
    }
}
