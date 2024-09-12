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
    public Animator anim;
    public GameObject laserPrefabLeft;
    public GameObject laserPrefabRight;
    public GameObject laserPrefabUp;
    public GameObject laserPrefabDown;
    public SpriteRenderer Daverenderer;
    public Sprite left;
    public Sprite right;
    public Sprite up;
    public Sprite down;
    [SerializeField]
    public int numLasers = 3;
    public float laserSpeed = 10f;
    public int lastMovement = 0;


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        pressKey();
        lasers();
    }
    void pressKey()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime * moveForce;
        if (movementX > 0)
        {
            lastMovement = 1;
        }
        else if (movementX < 0)
        {
            lastMovement = -1;
        }
        else if (movementY > 0)
        {
            lastMovement = 2;
        }
        else if (movementY < 0)
        {
            lastMovement = -2;
        }
        animations();
    }
    void lasers()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (lastMovement == -1)
            {

                GameObject laser = Instantiate(laserPrefabRight,
                                               transform.position,
                                               Quaternion.identity);
                SpriteRenderer renderer = laser.GetComponent<SpriteRenderer>();
                renderer.sortingOrder = 1;
                Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * -1 * laserSpeed;
            }
            else if (lastMovement == 1)
            {
                GameObject laser = Instantiate(laserPrefabLeft,
                                                           transform.position,
                                                           Quaternion.identity);
                SpriteRenderer renderer = laser.GetComponent<SpriteRenderer>();
                renderer.sortingOrder = 1;
                Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * 1 * laserSpeed;
            }
            else if (lastMovement == 2)
            {
                GameObject laser = Instantiate(laserPrefabUp,
                                              transform.position,
                                              Quaternion.identity);
                SpriteRenderer renderer = laser.GetComponent<SpriteRenderer>();
                renderer.sortingOrder = 1;
                Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
                rb.velocity = transform.up * 1 * laserSpeed;
            }
            else if (lastMovement == -2)
            {
                GameObject laser = Instantiate(laserPrefabDown,
                                              transform.position,
                                              Quaternion.identity);
                SpriteRenderer renderer = laser.GetComponent<SpriteRenderer>();
                renderer.sortingOrder = 1;
                Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
                rb.velocity = transform.up * -1 * laserSpeed;
            }
        }

    }
    void animations()
    {
        if (movementX > 0f)
        {
            Daverenderer.sprite = right;
        }
        else if (movementX < 0f)
        {
            Daverenderer.sprite = left ;

        }
        if (movementY > 0f)
        {
            Daverenderer.sprite = up;
        }
        else if (movementY< 0f)
        {
            Daverenderer.sprite = down;

        }
    }
}
