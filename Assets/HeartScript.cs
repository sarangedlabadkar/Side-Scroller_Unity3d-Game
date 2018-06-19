using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour {
	public GameObject h1,h2,h3,h4,h5;
	public static int hearts = 5;
	// Use this for initialization
	void Start () {
		h1 = GameObject.FindGameObjectWithTag ("h1");
		h2 = GameObject.FindGameObjectWithTag ("h2");
		h3= GameObject.FindGameObjectWithTag ("h3");
		h4 = GameObject.FindGameObjectWithTag ("h4");
		h5 = GameObject.FindGameObjectWithTag ("h5");

		
	}
	
	// Update is called once per frame
	void Update () {
		switch (hearts) {
		case 5:
			h1.SetActive (true);
			h2.SetActive (true);
			h3.SetActive (true);
			h4.SetActive (true);
			h5.SetActive (true);

			
			break;
		case 4:
			Debug.Log ("inside 4");
			h1.SetActive (true);
			h2.SetActive (true);
			h3.SetActive (true);
			h4.SetActive (true);
			h5.SetActive (false);


			break;

		}
		
	}
}
