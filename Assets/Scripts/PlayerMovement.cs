using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float walkingForce;
    public float breakingForce;
    public float maxForce;
    public float maxSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Movement();
	}

    private void Movement()
    {
        Vector2 force = Vector2.zero;

        force.x += Input.GetAxis("Horizontal") * walkingForce;
        force.y += Input.GetAxis("Vertical") * walkingForce;

        if (force.magnitude == 0)
        {
            if(rb.velocity.magnitude > 0.1f)
            {
                force = -rb.velocity;
                force.Normalize();
                force *= breakingForce;
            }

            else
            {
                rb.velocity = Vector2.zero;
            }
        }

        if (force.magnitude > maxForce)
        {
            force.Normalize();
            force *= maxForce;
        }

        rb.AddForce(force);
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity.Normalize();
            rb.velocity *= maxSpeed;
        }
    }

}
