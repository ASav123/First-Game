using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullets : MonoBehaviour
{
    public Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void delete(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);

        }
    }
    // Update is called once per frame
    void Update()
    {
        delete(collider);
    }
}
