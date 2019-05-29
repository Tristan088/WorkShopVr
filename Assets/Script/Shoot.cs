using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float Shooting;
    public float speed;
    public float newRotation;

    public float destroyDelay;

    public string shoot;
    
    public GameObject foreuse;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        Shooting = Input.GetAxis(shoot);

        if (Shooting > 0.5f)
        {
            Debug.Log("CAAAA MAAAAARCHEEEEE!!");

            foreuse.GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime;

            foreuse.GetComponent<Foreuse>().speedRotation = newRotation;
            foreuse.transform.SetParent(null);
            Destroy(gameObject, destroyDelay);
        }
        
    }


}
