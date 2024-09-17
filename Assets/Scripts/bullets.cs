using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        //if (collision.CompareTag("ghost"))
        //{
        //    audio.Play();
        //}
        if (collision.CompareTag("boundary") || collision.CompareTag("ghost"))
        {
                
            Destroy(gameObject);
            
        }
       
    }

}
