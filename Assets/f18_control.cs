using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f18_control : MonoBehaviour
{
    public float speed = 1000.0f;
    public float rotationSpeed = 5.0f;
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

        Vector3 movement = new Vector3(verticalInput, 0, horizontalInput);
        Vector3 rotation = new Vector3( Input.GetAxis("Mouse X"),Input.GetAxis("Mouse X")/10,  -Input.GetAxis("Mouse Y"));
        transform.Rotate(rotation * rotationSpeed);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
    