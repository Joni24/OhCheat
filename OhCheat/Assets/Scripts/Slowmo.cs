using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowmo : MonoBehaviour
{
    [SerializeField]
    private float factor = 2f;

    private void OnEnable()
    {
        Time.timeScale /= factor;
    }

    private void OnDisable()
    {
        Time.timeScale *= factor;
    }
}
