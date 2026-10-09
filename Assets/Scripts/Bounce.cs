using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
     private Rigidbody2D rb;
     public float speed = 5000f;

     private void Start()
     {
         rb = GetComponent<Rigidbody2D>();
 
     }

    
 
     void OnCollisionEnter2D(Collision2D collision)
 {
     if( collision.gameObject.tag == "wall")
     {
         float bounce = 400f; 
         rb.AddForce(collision.contacts[0].normal * bounce);
     }
 }

 }
