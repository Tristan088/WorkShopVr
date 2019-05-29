using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            transform.position = transform.position + Vector3.up * _speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - Vector3.up * _speed * Time.deltaTime;

        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position - Vector3.forward * _speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + Vector3.forward * _speed * Time.deltaTime;
        }

        
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(5f, 0f, 0f); 
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(-5f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0f, 0f, -5f);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(0f, 0f, 5f);
        }
    }
}
