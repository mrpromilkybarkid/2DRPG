using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed = 5f;
	public float jumpPower = 700f;
	public float lerpVal = 0.2f;
	public bool grounded;
	public Transform groundCheck;
	public float groundRadius = 0.5f;
	public LayerMask ground;

	public void FixedUpdate() 
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, ground);

		rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rigidbody2D.velocity.y);
	}

	public void Update()
	{
		if (grounded && Input.GetButtonDown("Jump"))
		{
			grounded = false;
			rigidbody2D.AddForce(new Vector2(0, jumpPower));
		}
	}
}
