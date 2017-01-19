using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5.0F;
	private Vector3 moveDirection = Vector3.zero;
	public bool canMove = false;
	public float gravity = 1.0f;
	public float antigravity = 1.5f;
	public Wind wind;

	void Update () {
		if (canMove) {

			CharacterController controller = GetComponent<CharacterController> ();

			// Add gravity
			moveDirection = new Vector3 (0, gravity*(-1.0f), 0);
			moveDirection = transform.TransformDirection (moveDirection);

			if (Input.GetButton ("Fire1")) {
				Debug.Log("test");

				// Add antigravity
				moveDirection = moveDirection + (new Vector3 (0, antigravity, 0));
				moveDirection = transform.TransformDirection (moveDirection);

			}

			// Add windforce
			moveDirection += wind.getWind(gameObject.transform.position);

			// Apply force
			moveDirection *= speed;
			controller.Move (moveDirection * Time.deltaTime);
		}
	}
}
