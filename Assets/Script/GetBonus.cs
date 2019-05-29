using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBonus : MonoBehaviour
{
    [Range(0,5)]
    public float catchRadius = 1;

    private Vector3 positionBaseToCatch;
    public LayerMask bonusLayerMask;

    private void Update()
    {
        positionBaseToCatch = transform.position + transform.up/5;
        Collider[] objectsInRange = Physics.OverlapSphere(positionBaseToCatch, catchRadius, bonusLayerMask);
        if (objectsInRange.Length>0)
        {
            Debug.Log("P");
            foreach(Collider obj in objectsInRange)
            {
                Destroy(obj.gameObject);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(positionBaseToCatch, catchRadius);
    }
}
