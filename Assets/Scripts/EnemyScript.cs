﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private WeaponScript weapon;

	void Awake(){
		// Retrieve the weapon only once
		weapon = GetComponentInChildren<WeaponScript> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (weapon != null && weapon.CanAttack) {
			weapon.Attack(true);
		}
	}
}
