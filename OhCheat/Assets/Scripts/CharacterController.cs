using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce;
    public float bounds = 20;
    
    private Rigidbody2D rb;
    private Camera mainCamera;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        LayerMask mask = LayerMask.GetMask("Floor");
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.65f, mask);
        
        if (rb != null && hit.collider != null && Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    
    private void Update()
    {
        var screenPos = mainCamera.WorldToScreenPoint(transform.position);
        var rect = mainCamera.pixelRect;
        rect.min -= new Vector2(bounds, bounds);
        rect.max += new Vector2(bounds, bounds);
        
        if (!rect.Contains(screenPos)) {
            GameManager.gameManager.Restart();
        }
    }
}
