using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 2;
	public bool isEnemy = true;

	void OnTriggerEnter2D(Collider2D collider){

		// Is it a shot?
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) {
			//Avoid friendly fire
			if (shot.isEnemyShot != isEnemy){

				hp -= shot.damage;
				// destroy the shot. TARGET THE gameobject, else it will
				// remove the script itself
				Destroy(shot.gameObject);

				if (hp <= 0)
				{
					//DIE LIAO
					Destroy(gameObject);
				}
			}

		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
