using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private Vector3 moveDirection = Vector3.zero;
	public bool canMove = false;
	public float gravity = 2f;
	public float antigravity = 3f;
	public Wind wind;
	public GameObject fire;

	void Update () {
		if (canMove) {

			CharacterController controller = GetComponent<CharacterController> ();

			// Add gravity
			moveDirection = new Vector3 (0, gravity*(-1.0f), 0);

			fire.SetActive (false);
			if (Input.GetButton ("Fire1") || Input.GetButton("Submit")) {
				// Add antigravity
				dofire();
			}

			// Add windforce
			moveDirection += wind.getWind(gameObject.transform.position);

			// Apply force
			controller.Move (moveDirection * Time.deltaTime);
		}
	}

	private void dofire(){
		moveDirection = moveDirection + (new Vector3 (0, antigravity, 0));
		fire.SetActive (true);
	}
}
