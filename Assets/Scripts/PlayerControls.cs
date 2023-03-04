using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    Rigidbody rb;
    float movementSpeed = 6f;
    float jumpForce = 5f;

    

    

  
  


    private void FixedUpdate()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
       

        //if (direction.magnitude >= 0.1f)
        {
           // float targetAngle = Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg;
            //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
           // transform.rotation = Quaternion.Euler(0f, angle, 0f);

           //controller.Move(direction * speed * Time.deltaTime);
           // Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f)* Vector3.forward;


        }

      

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);


        if (Input.GetKeyDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }




    }
}
