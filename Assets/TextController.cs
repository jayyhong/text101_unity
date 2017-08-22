using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Hello world";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			text.text = "You wake up to find yourself in a prison cell, you" +
						"have to escape before the ward touches your butt again." +
						"There are som dirty sheets on the bed, a mirror on the wall, "+
						"and the door is locked from the outside.\n\n" +
						"Press S to View Sheets \n" +
						"Press M to View Mirror\n" +
						"Press L to View Lock";
		}
	}
}
