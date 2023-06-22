using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    private Vector3 movement;
    public float movementSpeed = 0.1f;
    private bool isMoving = false;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (isMoving)
            transform.position += movement * movementSpeed;

    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        if (!isMoving)
            isMoving = value.started;
        else
            isMoving = !value.canceled;
        Vector2 inputMovement = value.ReadValue<Vector2>();
        movement = new Vector3(inputMovement.x, inputMovement.y, 0);
        //smoothInputMovement = Vector3.Lerp(smoothInputMovement, movement, Time.deltaTime * movementSmoothingSpeed);
    }

    public void OnShoot(InputAction.CallbackContext value)
    {
        bool actionStarted = value.ReadValue<bool>();
        if (actionStarted)
        {
            //shoot
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
