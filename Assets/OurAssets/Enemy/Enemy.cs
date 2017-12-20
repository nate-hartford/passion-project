using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 100;
	public Bullet bullet;
	public GameObject enemyBullet;

	public float fireRate = .1f;
	public float nextFire;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (enemyBullet, transform.position, bullet.transform.rotation);
		}
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		if (currentHealth <= 0) {
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bullet") {
			TakeDamage (bullet.damage);

			Debug.Log ("Health Remaining: " + currentHealth);
		}
	}
}
