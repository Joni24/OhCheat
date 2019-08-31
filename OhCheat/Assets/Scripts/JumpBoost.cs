using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    [SerializeField]
    private float factor = 2f;

    private void OnEnable()
    {
        GetComponent<CharacterController>().jumpForce *= factor;
    }

    private void OnDisable()
    {
        GetComponent<CharacterController>().jumpForce /= factor;
    }
}
