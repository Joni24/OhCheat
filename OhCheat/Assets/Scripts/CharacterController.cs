using System;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class CharacterController : MonoBehaviour
{
    public float jumpForce;
    public float floatHeight = 0.1f;
    
    private Rigidbody2D rb;
    private bool canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce);
        }
        
    }
}
