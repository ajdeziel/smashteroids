﻿using UnityEngine;
using System.Collections;

public class EnemyShipDumbAI : EnemyShipBaseAI {

	#region functions to be implemented/overriden
	// should we think this step
	protected override bool ShouldThink() {
		return false;
	}

	// do any thinking and calculations about how to act this step
	protected override void Think() {

	}
	
	// do any movement after thinking this step
	protected override void Move() {
		// simply move to the left at a constant speed
		transform.Translate(Vector3.left * ship.baseStats.moveSpeed * Time.deltaTime);
	}
	
	// do any shooting after thinking this step
	protected override void Shoot() {
		// load and instantiate the bullet
		var bulletPrefab = Resources.Load("EnemyBullet");
		var bulletGo = (GameObject) GameObject.Instantiate(bulletPrefab, ship.GetRandomGunPoint(), Quaternion.identity);
		var bullet = bulletGo.GetComponent<EnemyBullet>();

		if (bullet != null) {
			bullet.speed = ship.baseStats.bulletSpeed;
		}
	}
	#endregion functions to be implemented/overriden
}