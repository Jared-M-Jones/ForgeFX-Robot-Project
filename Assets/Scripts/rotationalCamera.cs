using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// rotates the camera around the gameObject using the W/A/S/D keys and rolls the camera using the Q/R keys

public class RotationalCamera : MonoBehaviour
{
    // target to rotate around
    [SerializeField] private GameObject target;
    [SerializeField] private Camera mainCam;
    [SerializeField] private float camRotSpeed = 40.0f;

    private float verticalInput;
    private float horizontalInput;
    private float rollInput;

    private void Start()
    {
        // initializes the camera position and orientation
        mainCam = Camera.main;
        mainCam.transform.position = new Vector3(0, 0.2f, 0.5f);
        mainCam.transform.LookAt(target.transform.position);
    }

    private void Update()
    {
        ApplyVerticleInput();

        ApplyHorizontalInput();

        ApplyRollInput();
    }


    private void ApplyVerticleInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        mainCam.transform.RotateAround(target.transform.position, mainCam.transform.right, camRotSpeed * verticalInput * Time.deltaTime);
    }

    private void ApplyHorizontalInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        mainCam.transform.RotateAround(target.transform.position, Vector3.up, camRotSpeed * horizontalInput * Time.deltaTime);
    }

    private void ApplyRollInput()
    {
        rollInput = Input.GetAxis("Roll");
        mainCam.transform.RotateAround(target.transform.position, mainCam.transform.forward, camRotSpeed * rollInput * Time.deltaTime);
    }
}
