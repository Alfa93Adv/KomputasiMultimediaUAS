using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {
	public void Menu_Quit() {
        Debug.Log("Keluar Game");
        Application.Quit();
	}
}
