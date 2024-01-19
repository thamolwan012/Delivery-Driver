using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //public Transform carTransform;
    //public Vector3 offset = new Vector3(0f, 5f, -10f);
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
        //transform.position = carTransform.position + offset;

        //transform.LookAt(carTransform);
    }
}

