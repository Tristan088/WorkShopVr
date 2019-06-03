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
    
    public Foreuse foreuse;

    public ParticleSystem DrillFireShot;
        

    public GameObject DrillShotPoint;    
    


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

            foreuse.GetComponent<Rigidbody>().velocity = transform.forward * speed ;

            foreuse.speedRotation = newRotation;
            foreuse.SmokeForeuse.Play();

            foreuse.transform.SetParent(null);
            DrillFireShot.Play();

            Destroy(gameObject, destroyDelay);

           
        }
        
    }


}
