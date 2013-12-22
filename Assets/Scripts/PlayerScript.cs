using UnityEngine;
using System.Collections;

// Oh noes this is just a sample comment line to show that I can actually comment!
// And just adding another line for the lulz

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Vector2 speed = new Vector2(50,50);
	
	// Update is called once per frame
	void Update () {
		// "Retrieve axis information". Also from aliens
		// 0 = idle / -1 = left / 1 = right
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		// "Movement per direction" Adding nuclear power~
		Vector3 movement = new Vector3 (
			speed.x * inputX,
			speed.y * inputY
			);
		// "Relative to the time". Sync to world clock!!!
		movement *= Time.deltaTime;

		// "Move the game object" Move la! Tell you faster move!
		transform.Translate (movement);

		// SHOOTINGGGG

		bool shoot = Input.GetButtonDown ("Fire1");
		shoot |= Input.GetButtonDown ("Fire2");

		if (shoot) {
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				weapon.Attack(false);
			}
		}
	
	}
}
