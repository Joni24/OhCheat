using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAI : MonoBehaviour
{
    private bool facingRight = false;
    public float speed = 2f;
    public float runningDistance = 3f;
    private float distanceLeft;

    private new Rigidbody2D rigidbody;
    private new SpriteRenderer renderer;

    public bool FacingRight {
        get
        {
            return renderer.flipX;
        }
        set
        {
            renderer.flipX = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();

        distanceLeft = runningDistance / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        distanceLeft -= rigidbody.velocity.magnitude * Time.deltaTime;

        if (distanceLeft < 0)
        {
            distanceLeft = runningDistance;
            facingRight = !facingRight;
        }

        rigidbody.velocity = new Vector2(facingRight ? -speed : speed, rigidbody.velocity.y);
    }
}
