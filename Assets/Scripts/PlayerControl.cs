using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    // private float speed = 5.0f;
    private float turnRate = 30.0f;
    private float currentVelocity = 0.0f;
    private float accelerationConstant = 0.05f;
    private float acceleration = 0.0f;
    private float maxAcceleration = 3.0f;
    private float maxVelocity = 10.0f;
    // private float timeAccelerating = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveForward();
    }

    private void moveForward()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        /*
        // timeAccelerating increases the longer the key is held down for
        timeAccelerating += Time.deltaTime;
    
        // Accelerating for 0 seconds if it is not currently accelerating
        if (forwardInput == 0){
            timeAccelerating = 0.0f;
        }
        */

        // Acceleration is in the direction of the input, based on how long it has been accelerating
        acceleration = forwardInput * accelerationConstant;
        acceleration = Mathf.Max(acceleration, -maxAcceleration);
        acceleration = Mathf.Min(acceleration, maxAcceleration);

        currentVelocity += acceleration;
        currentVelocity = Mathf.Max(currentVelocity, -maxVelocity);
        currentVelocity = Mathf.Min(currentVelocity, maxVelocity);

        this.transform.Translate(Vector3.up * Time.deltaTime * currentVelocity);
        this.transform.Rotate(Vector3.back, turnRate * Time.deltaTime * horizontalInput * currentVelocity);
        
    }
}
