using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootlazer : MonoBehaviour
{
    private float shooter;
    public float range = 100f;

    public string shoot;

    public GameObject LazerGun;

    public ParticleSystem flash;

    
    void Update()
    {
        shooter = Input.GetAxis(shoot);

        if (shooter > 0.5f)
        {
            Debug.Log("CAAAA TIIIIIRRE!!");
            IsShoot();
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
