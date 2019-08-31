using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField]
    private CameraController camera;
    [SerializeField]
    private float factor = 2f;

    private void OnEnable()
    {
        camera.speed *= factor;
    }

    private void OnDisable()
    {
        camera.speed /= factor;
    }
}
