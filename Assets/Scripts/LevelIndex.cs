using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIndex : MonoBehaviour {

	public int levelIndex;

	void Start(){
		DontDestroyOnLoad (this.gameObject);
	}
}
