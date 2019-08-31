using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().gravityScale *= -1;
        GetComponent<SpriteRenderer>().flipY = true;
    }

    private void OnDisable()
    {
        GetComponent<Rigidbody2D>().gravityScale *= -1;
        GetComponent<SpriteRenderer>().flipY = false;
    }
}
