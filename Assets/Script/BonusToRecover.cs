using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusToRecover : MonoBehaviour
{
    [Range(0, 100)]
    public float rangeX;
    [Range(0, 100)]
    public float rangeY;

    [Range(1,10)]
    public float speed = 1;
    private GameObject Player;

    private Vector3 positionToReach;

    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        Player = GameObject.FindGameObjectWithTag("Player");
        positionToReach = Player.transform.position + new Vector3(Random.Range(-rangeX, rangeX), Random.Range(-rangeY, rangeY));
        Debug.Log(positionToReach);
        direction = positionToReach - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += direction * (1/speed) * Time.deltaTime ;
    }
}
