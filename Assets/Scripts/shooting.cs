using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour

{
    public GameObject laserPrefab;
    public int numLasers = 3;
    public float laserSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lasers();
    }
    void lasers()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject laser = Instantiate(laserPrefab,
                                           transform.position,
                                           Quaternion.identity);
            SpriteRenderer renderer = laser.GetComponent<SpriteRenderer>();
            renderer.sortingOrder = 1;
            Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * -1 * laserSpeed;

        }

    }

}
