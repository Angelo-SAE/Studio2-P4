using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private float mouseSensitivity;
    private float mouseX, mouseY, xRotation, yRotation;

    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }

    void Update()
    {
      SetMouseInput();
      RotateCamera();
    }

    private void SetMouseInput()
    {
      mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
    }

    private void RotateCamera()
    {
      yRotation += mouseX;
      xRotation -= mouseY;
      xRotation = Mathf.Clamp(xRotation, -90f , 90f);

      transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
      player.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
