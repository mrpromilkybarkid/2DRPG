using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed = 5f;
	public float lerpVal = 0.2f;

	public Sprite spr_up;
	public Sprite spr_down;
	public Sprite spr_left;
	public Sprite spr_right;

	public SpriteRenderer sr;

	public void FixedUpdate() 
	{
		rigidbody2D.velocity = new Vector2(
			Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, lerpVal), rigidbody2D.velocity.y);
	}
}
