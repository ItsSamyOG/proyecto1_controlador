using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // Movimiento lateral
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        // Rotacion 
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);


    }
}
