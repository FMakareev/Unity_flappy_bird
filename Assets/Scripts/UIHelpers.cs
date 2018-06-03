using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelpers : MonoBehaviour {
	
	private bool _paused = false;

	public GameObject panel;
	
	// Use this for initialization
	void Start()
	{
		_paused = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			OnPausedToggle();
		}
	}

	public void OnPausedToggle()
	{
		if (!_paused)
		{
			Time.timeScale = 0;
			_paused = true;
			panel.SetActive(true);
		}
		else
		{
			Time.timeScale = 1;
			_paused = false;
			panel.SetActive(false);
		}
	}
	
	public void RestartLevel()
	{
		Application.LoadLevel("Game");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
