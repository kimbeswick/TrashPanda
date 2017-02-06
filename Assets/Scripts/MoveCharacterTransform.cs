using UnityEngine;
using System.Collections;

public class MoveCharacterTransform : MonoBehaviour {

	// Rigidbody2D 
	public Rigidbody2D someBody;
	// Bool To See Which Way Character Is Facing
	bool characterFacingRight = true;
	// Speed At Which To Move Character 
	public float speed;

	// Animator 
	Animator characterAnimation;

	// Start Function
	void Start()
	{
		characterAnimation = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		// Get Arrow Key Right Or Left
		float movement = Input.GetAxis ("Horizontal");

		// Create Animator Variable To Check Whether To Transition From One Animation To Another
		characterAnimation.SetFloat ("Movement Speed", Mathf.Abs (movement));

		// Change Velocity Based On Speed and Movement of Right or Left
		someBody.velocity = new Vector2(movement * speed, 0.0f);

		// Check If We Need to Flip The Animation
		if (movement > 0 && !characterFacingRight) 
		{
			FlipAnimation ();
		} 
		else if (movement < 0 && characterFacingRight) 
		{
			FlipAnimation();
		}

	}

	void FlipAnimation()
	{
		// Set Character Facing Direction To Opposite or False
		characterFacingRight = !characterFacingRight;
		Vector3 currentScale = transform.localScale;
		// Multiply Current Scale By Negative To Flip Direction
		currentScale.x *= -1;
		transform.localScale = currentScale;
	}
}
