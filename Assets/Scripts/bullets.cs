using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ghost") || collision.CompareTag("boundary"))
        {
            Destroy(gameObject);
        }
    }
}
