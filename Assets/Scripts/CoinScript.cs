using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Coin")
			print ("Collected");
		ScoreText.coinAmount += 1;
		Destroy (gameObject);

	}





}
