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

	public void Start()
	{
		Animator anim = this.GetComponent<Animator>();
		SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
	}

	public void FixedUpdate() 
	{
		rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, lerpVal), Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, lerpVal));
	
		if (Input.GetAxis("Vertical") > 0)
		{
			sr.sprite = spr_up;
		}
		else if (Input.GetAxis("Vertical") < 0)
		{
			sr.sprite = spr_down;
		}

		if (Input.GetAxis("Horizontal") > 0)
		{
			sr.sprite = spr_right;
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			sr.sprite = spr_left;
		}
	}
}
