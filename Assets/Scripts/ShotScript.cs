using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	// Damage inflicted
	public int damage = 1;
	// Projectile damage player or enemies
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
	
		// Limited time to live to avoid mem leak
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
