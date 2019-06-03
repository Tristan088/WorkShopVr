using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNewBonus : MonoBehaviour
{
    bool alreadySpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(alreadySpawned == false && WordSettings.Instance.nbBriqueBrake % 10 == 0 && WordSettings.Instance.nbBriqueBrake !=0)
        {
            alreadySpawned = true;
            //SPAWN//
        }
        else if(WordSettings.Instance.nbBriqueBrake % 10 !=0)
        {
            alreadySpawned = false;
        }
    }
}
