using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public GameObject target; // Target to rotate around
    private Camera mainCam;
   // private float rotSpeed = 40.0f; // Speed of Rotation
    private float verticalInput, horizontalInput, rollInput;
   // private float angleX, angleY, angleZ;

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

        /* // rotate the camera around the x-axis based on up/down or w/s key inputs
         transform.RotateAround(target.transform.position, Vector3.left, cameraRotationSpeed * verticalInput * Time.deltaTime);

         // rotate the camera around the y-axis based on left/right or a/d key inputs
         transform.RotateAround(target.transform.position, Vector3.up, cameraRotationSpeed * horizontalInput * Time.deltaTime);

         // Roll the camera around the z-axis based on q/r key inputs
         transform.RotateAround(target.transform.position, Vector3.forward, cameraRotationSpeed * rollInput * Time.deltaTime);*/

        mainCam = Camera.main;

        //  mainCam.transform.position = target.position;
       /* if (Input.GetAxis("Vertical") == 1.0f)
            mainCam.transform.Rotate(new Vector3(1,0,0), Space.Self);
        if (Input.GetAxis("Horizontal") == 1.0f)
        mainCam.transform.Rotate(new Vector3(0, 1, 0), Space.Self);

        mainCam.transform.Translate(new Vector3(0, 0, 0));*/
    }

}
