using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public GameObject Instruction;
	public GameObject MainMenu;

	public void StartGame()
	{
		SceneManager.LoadScene ("Scene01");
	}

	void Start (){

		Instruction.SetActive (false);

	}
	public void Tutorial()
	{
		Instruction.SetActive (true);
		MainMenu.SetActive (false);
	}


	public void main_menu ()
	{
		MainMenu.SetActive (true);
		Instruction.SetActive (false);
	}

	public void game()
	{
		SceneManager.LoadScene (1);
	}	


	public void exit()
	{
		
		Application.Quit ();

	}

}
