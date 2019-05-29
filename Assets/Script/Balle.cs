using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{

    private Rigidbody _rb;
    public float _speed;
    private bool _isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MoveRacket>() && !_isMoving)
        {
            _isMoving = true;
            transform.rotation = collision.transform.rotation;
            _rb.AddForce(transform.up * _speed);
        }
    }
}
