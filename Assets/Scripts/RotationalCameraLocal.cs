using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalCameraLocal : MonoBehaviour
{
    public GameObject target; // Target to rotate around
    private Camera mainCam;
    private float cameraRotationSpeed = 10.0f; // Speed of Rotation
    private float moveY;
    private float moveX;
    private float rotationY = 0.0f;
    private float rotationX = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

        // Gets initial local rotation
        Vector3 rotation = transform.localEulerAngles;
        rotationY = rotation.y;
        rotationX = rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        moveCamera(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), cameraRotationSpeed);
    }

    void moveCamera(float horizontal, float verticle, float camSpeed)
    {
        moveX = horizontal;
        moveY = -verticle;

        rotationY += moveY * camSpeed;
        rotationX += moveX * camSpeed;

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
    }
}