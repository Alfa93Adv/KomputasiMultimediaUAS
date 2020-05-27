﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMati : MonoBehaviour {
	public bool hasDied;

	// Use this for initialization
	void Start () {
		hasDied = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < -10){
			hasDied = true;
		}
		if(hasDied == true){
			StartCoroutine("Die");
		}
	}
	IEnumerator Die(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		yield return null;
	}
}
