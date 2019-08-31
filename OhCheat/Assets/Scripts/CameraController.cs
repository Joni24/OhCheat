using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2f;

    private void OnDisable()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    
    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.right;
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
