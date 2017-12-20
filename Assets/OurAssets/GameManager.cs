using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;



	void Awake()
	{
		instance = this;
	}

	public void StartGame()
	{
		SceneManager.LoadScene (1);
	}

	public void StartScreen()
	{
		SceneManager.LoadScene (0);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
