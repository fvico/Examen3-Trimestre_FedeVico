using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float sensivility = 100f;
    public Transform playerTramsform;

    private float movimientoCabeza;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensivility * Time.deltaTime;

        playerTramsform.Rotate(Vector3.up * mouseX);

        movimientoCabeza -= mouseY;
        movimientoCabeza = Mathf.Clamp(movimientoCabeza, -90f, 90f);

        this.transform.localRotation = Quaternion.Euler(movimientoCabeza, 0f, 0f);

    }
}
