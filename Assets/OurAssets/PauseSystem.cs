using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseSystem : MonoBehaviour {

	public GameObject pausePanel;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) 
		{
			pausePanel.SetActive (true);
			Time.timeScale = 0f;
		}
	}

	public void Resume()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}
}
