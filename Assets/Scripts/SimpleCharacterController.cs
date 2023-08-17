using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private Rigidbody body;

    float horizontal;
    float vertical;

    private void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        body.velocity = new Vector3(horizontal * movementSpeed, 0, vertical * movementSpeed);
    }
}
