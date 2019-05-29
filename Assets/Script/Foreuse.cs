using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreuse : MonoBehaviour
{
    public float speedRotation = 200;

    void Update()
    {
        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
    }
}
