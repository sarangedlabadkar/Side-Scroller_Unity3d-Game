﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


		Invoke ("GotoMainMenu", 2f);
	}


	void GotoMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

}
