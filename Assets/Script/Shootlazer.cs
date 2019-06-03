using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootlazer : MonoBehaviour
{
    private float shooter;
    public float range = 1000f;

    public string shoot;

    private bool Atire = false;

    public GameObject LazerGun;

    public ParticleSystem Lazer;
    public Transform LazerPoint;
    public ParticleSystem Lazer1;
    public Transform LazerPoint1;

    public float destroyDelay;

    public int Munition = 5;


    void Update()
    {
        
        shooter = Input.GetAxisRaw(shoot);

        if ((shooter > 0.5f) && (Atire == false))
        {
            Atire = true;
            Munition--;
            Debug.Log("CAAAA TIIIIIRRE!!");
            IsShoot();
             Lazer.Play();
             Lazer1.Play();

            if (Munition <= 0) 
            {
                Destroy(gameObject,destroyDelay);
            }
        }

        if ((Atire == true) && (shooter < 0.5f))
        {
            Atire = false;
        }
    }

    private void IsShoot()
    {

        //flash.Play();
        RaycastHit hit;
       if (Physics.Raycast(LazerGun.transform.position, LazerGun.transform.forward, out hit , range))
        {
            Debug.Log(hit.transform.name);
        }

    }
}
