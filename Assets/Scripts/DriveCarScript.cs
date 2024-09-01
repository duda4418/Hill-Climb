using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D frontTireRB;
    [SerializeField] private Rigidbody2D backTireRB;
    [SerializeField] private Rigidbody2D carRB;
    [SerializeField] private float speed = 150f;
    [SerializeField] private float rotaionSpeed = 300f;
    private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        frontTireRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        backTireRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        carRB.AddTorque(moveInput * rotaionSpeed * Time.fixedDeltaTime);
    }
}
