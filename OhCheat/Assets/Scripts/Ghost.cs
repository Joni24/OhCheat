using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
