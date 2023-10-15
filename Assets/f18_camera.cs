using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f18_camera : MonoBehaviour
{
    public float speed = 100.0f;

    public float rotationSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, -verticalInput);
        Vector3 rotation = new Vector3( -Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse X"), 0 );
        transform.Rotate(rotation * rotationSpeed);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
