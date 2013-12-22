using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	//Object speed
	public Vector2 speed = new Vector2 (5, 5);

	// Moving Direction
	public Vector2 direction = new Vector2(-1,0);
	// Update is called once per frame
	void Update () {
	
		//MOVEMENT
		Vector3 movement = new Vector3 (
			speed.x * direction.x,
			speed.y * direction.y,
			0);
		movement *= Time.deltaTime;
		transform.Translate (movement);


	}
}
