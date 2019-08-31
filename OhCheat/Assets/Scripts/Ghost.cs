using UnityEngine;

public class Ghost : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetComponent<CharacterController>().canJump = true;
        transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
    }

    private void OnDisable()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetComponent<CharacterController>().canJump = false;
        transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.4f);
    }
}
