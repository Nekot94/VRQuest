using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VRController : MonoBehaviour
{
    public Transform cam;
    public float speed = 3;
    public float toggleAngle = 20;

    Rigidbody body;

    bool isMoving;


    void Start ()
    {
        body = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        isMoving = cam.eulerAngles.x >= toggleAngle && cam.eulerAngles.x < 90;
        //isMoving = true;
        if (isMoving)
        {
            Vector3 forward = cam.TransformDirection(Vector3.forward);
            body.velocity = forward * speed;
        }
	}
}
