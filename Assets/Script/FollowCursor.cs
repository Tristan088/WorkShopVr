using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    float distance = 1.0f;
    bool useInitialCameraDistance = true;

    private float actualDistance;
    // Start is called before the first frame update
    void Start()
    {
        if(useInitialCameraDistance)
        {
            Vector3 toObjectVector = transform.position - Camera.main.transform.position;
            Vector3 linearDistanceVector = Vector3.Project(toObjectVector, Camera.main.transform.forward);
            actualDistance = linearDistanceVector.magnitude;
        }
        else
        {
            actualDistance = distance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = actualDistance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
