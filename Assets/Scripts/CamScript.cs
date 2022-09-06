using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameObject target; // Target to rotate around
    private Camera mainCam;
    private float camRotSpeed = 40.0f; // Speed of Rotation
    private float verticalInput, horizontalInput, rollInput;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;

        // Initialize Camera position/rotation
        mainCam.transform.position = new Vector3(0, 0.2f, 0.5f);
        mainCam.transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
         // get the user's horizontal and vertical input
         verticalInput = Input.GetAxis("Vertical");
         horizontalInput = Input.GetAxis("Horizontal");
         rollInput = Input.GetAxis("Roll");

         // rotate the camera around the x-axis based on up/down or w/s key inputs
         mainCam.transform.RotateAround(target.transform.position, Vector3.left, camRotSpeed * verticalInput * Time.deltaTime);

         // rotate the camera around the y-axis based on left/right or a/d key inputs
         mainCam.transform.RotateAround(target.transform.position, Vector3.up, camRotSpeed * horizontalInput * Time.deltaTime);

         // Roll the camera around the z-axis based on q/r key inputs
         mainCam.transform.RotateAround(target.transform.position, Vector3.forward, camRotSpeed * rollInput * Time.deltaTime);
         //mainCam.transform.localRotation = Quaternion.Euler(0, 0, rollInput);

    }
}
