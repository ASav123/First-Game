using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet collided with: " + collision.gameObject.name);

        if (collision.CompareTag("boundary") || collision.CompareTag("ghost"))
        {
            Destroy(gameObject); 
        }
    }

}
