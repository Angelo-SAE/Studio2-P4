using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed, maxSpeed;
    private Rigidbody rb;
    private float horizontalInput, verticalInput;
    private bool moving;

    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
      TakeInput();
      MovePlayer();
    }

    private void TakeInput()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
      rb.AddForce(transform.right * horizontalInput * movementSpeed);
      rb.AddForce(transform.forward * verticalInput * movementSpeed);
      rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

      if(Mathf.Abs(horizontalInput) > 0.5 || Mathf.Abs(verticalInput) > 0.5 && !moving)
      {
        moving = true;
      }

      if(Mathf.Abs(horizontalInput) < 0.5 && Mathf.Abs(verticalInput) < 0.5 && moving)
      {
        moving = false;
        rb.velocity = Vector3.zero;
      }
    }

}
