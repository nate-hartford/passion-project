using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{

	public float moveSpeed = 5f;
	public bool canMoveVertically = true;
	public bool canMoveHorizontally = false;



	public float minX = -9.0f;
	public float maxX = 8.65f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (canMoveVertically == true) {
			
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}

		if (canMoveHorizontally == true) {
			transform.position = new Vector3 (Mathf.PingPong (Time.time * 2, maxX - minX) + minX, transform.position.y, transform.position.z);		

		}

	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "EnemyMovementBox") {
			Debug.Log ("Enemy Hit this box");

			canMoveVertically = false;
			canMoveHorizontally = true;
		}
	}
}
