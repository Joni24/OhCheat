using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce;
    public float dieAtYPosition = -10;
    
    private Rigidbody2D rb;
    private bool canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        LayerMask mask = LayerMask.GetMask("Floor");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.65f, mask);
        
        if (hit.collider != null && Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (this.transform.position.y < dieAtYPosition) {
            GameManager.gameManager.Restart();
        }
    }
}
