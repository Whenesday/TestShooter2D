using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	// Designer Variables
	// Projectile prefab for shooting 
	public Transform shotPrefab;

	// Cooldown in seconds between 2 shots
	public float shootingRate = 0.25f;
	private float shootCooldown;

	// Use this for initialization
	void Start () {
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	
		shootCooldown -= Time.deltaTime;
	}

	// Shooting from another script(the hell is this?!?)
	// Create a new projectile if possible

	public void Attack(bool isEnemy)
	{
		if (CanAttack) {

			shootCooldown = shootingRate;

			// Create a new shot
			var shotTransform = Instantiate(shotPrefab) as Transform;

			//Assign Position
			shotTransform.position = transform.position;

			//The "isEnemy" property
			ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
			if (shot != null)
			{
				shot.isEnemyShot = isEnemy;
			}

			// Make the weapon shot 'always towards it'. English much?!
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if (move != null)
			{
				// towards in 2D space is the right of the sprite
				move.direction = this.transform.right;

			}
		}
	}

	public bool CanAttack
	{
		get
		{
			return shootCooldown <= 0f;
		}
	}

}
