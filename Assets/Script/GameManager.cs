using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WordSettings.Instance.CheckBrique();
        WordSettings.Instance.nbBriqueBrake = 0;
        WordSettings.Instance.hpPlayer = 3;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
