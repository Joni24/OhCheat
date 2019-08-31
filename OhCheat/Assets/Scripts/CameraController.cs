using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 2f;
    
    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.right;
        characterController.transform.position = new Vector3(transform.position.x, characterController.transform.position.y,0f);
    }
}
