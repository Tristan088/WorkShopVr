using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreuse : MonoBehaviour
{
    public float speedRotation = 200;

    public ParticleSystem SmokeForeuse;
    public GameObject ForeusePoint;

    private void Start()
    {
        
    }

    void Update()
    {

        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
        
    }
}
