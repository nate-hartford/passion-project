using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	public float moveSpeed = 20f;
	public int damage = 20;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {



		transform.position -= transform.up * moveSpeed * Time.deltaTime;
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Debug.Log ("You Hit the Player!");
			Destroy (gameObject);
		}
	}
}
