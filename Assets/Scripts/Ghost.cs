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


    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

    }   


    //Ghost movement
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speedX, speedY);
    }
}
