using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce;
    
    private Rigidbody2D rb;

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce);    
        }
    }
}
