using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed = 5f;
	public float lerpVal = 0.2f;

	public void FixedUpdate() 
	{
		rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, lerpVal), Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, lerpVal));
	}
}
