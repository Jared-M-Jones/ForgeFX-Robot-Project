using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalCamera : MonoBehaviour
{
    public GameObject target; // Target to rotate around

    [SerializeField]
    private Camera mainCam;
    private float camRotSpeed = 40.0f; // Speed of Rotation
    private float verticalInput;
    private float horizontalInput;
    private float rollInput;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;

        mainCam.transform.position = new Vector3(0, 0.2f, 0.5f);
        mainCam.transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
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
