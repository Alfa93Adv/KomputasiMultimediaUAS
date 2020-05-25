using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscore : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D collision){
		switch(collision.name){
			case "coint1":
				Score.scoreAmount +=1;
				Destroy(collision.gameObject);
				break;
			case "coint2":
				Score.scoreAmount +=2;
				Destroy(collision.gameObject);
				break;
			case "coint3":
				Score.scoreAmount +=3;
				Destroy(collision.gameObject);
				break;
		}
	}
}
