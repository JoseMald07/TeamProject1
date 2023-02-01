using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    public float turnSpeed = 60;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    public float jumpForce = 5;

    private bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        
    }

    private void OnCollisionEnter (Collision collision)
    {
        if 
    }
}
