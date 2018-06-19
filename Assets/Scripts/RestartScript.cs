using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RestartScript : MonoBehaviour {

	public Button restartButton;
	public int levelIndex;

	void Start(){
		GameObject go = GameObject.Find ("LevelIndex");
		levelIndex = go.GetComponent<LevelIndex> ().levelIndex;
		Destroy (go);
		restartButton.onClick.AddListener (RestartGame);
	}
	void RestartGame(){
		SceneManager.LoadScene (levelIndex);
	}
}
