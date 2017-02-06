using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	
	private Rigidbody2D myRigidBody;
	private Animator myAnimator;

	[SerializeField]
	private float movementSpeed;
	private bool facingRight;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		myAnimator = GetComponent<Animator> ();
		facingRight = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		HandleMovement (horizontal);
		Flip(horizontal);
	}

	private void HandleMovement(float horizontal)
	{
		myRigidBody.velocity = Vector2.left;
		//myRigidBody.velocity = new Vector2(horizontal * movementSpeed, myRigidBody.velocity.y); // x == -1, y == 0
		//myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
	}

	private void Flip(float horizontal)
	{
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) 
		{
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
			

	}
}
