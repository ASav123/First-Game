using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float moveForce = 10f;
    public float movementX;
    public float movementY;
    public Rigidbody2D myBody;
    public SpriteRenderer sr;
    public Animator anim;
    public SpriteRenderer renderer;
    public Sprite left;
    public Sprite right;
    public Sprite up;
    public Sprite down;
    [SerializeField]
    public int numLasers = 3;
    public float laserSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        pressKey();
    }
    void pressKey()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime * moveForce;

    }
    void animations()
    {
        if (movementX > 0f)
        {
            renderer.sprite = right;
        }
        else if (movementX > 0f)
        {
            renderer.sprite = left ;

        }
        if (movementY > 0f)
        {
            renderer.sprite = up;
        }
        else if (movementY< 0f)
        { 
            renderer.sprite = down;

        }
    }
}