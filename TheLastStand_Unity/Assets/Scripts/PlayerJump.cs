using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {
	public float jspeed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float dashSpeed = 16.0F;
	public float jgravity = 20.0F;
	public CharacterController controller; 
	private Vector3 moveDirection = Vector3.zero;

	void Update() {

		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) {

			if (Input.GetKeyDown (KeyCode.Joystick1Button0))
				moveDirection.y = jumpSpeed;

		}

		moveDirection.y -= jgravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	

	}
}
