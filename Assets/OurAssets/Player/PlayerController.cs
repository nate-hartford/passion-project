using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	Vector3 moveDir = Vector3.zero;
	public GameObject bullet;
	public EnemyBullet enemyBullet;
	public GameObject deathScreen;
	private int lives;

	public float fireRate = .1f;
	public float nextFire;
	//private bool canFire;

	public int currentHealth;

	public int maxHealth = 100;


	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		moveDir.x = Input.GetAxis ("Horizontal");
		moveDir.z = Input.GetAxis ("Vertical");

		transform.position += moveDir * moveSpeed * Time.deltaTime;

		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (bullet, transform.position, bullet.transform.rotation);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") 
		{
			currentHealth = 0;

			Destroy (gameObject);
		} 
		else if (other.tag == "EnemyBullet") 
		{
			TakeDamage (enemyBullet.damage);
		}

	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 0) 
		{
			lives--;
			Destroy (gameObject);
		

			Debug.Log("new player created");
			deathScreen.SetActive (true);
		}
	}


}

