using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia {

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Seorang Prajurit dapat : ");
		Makan ();
		Tidur ();
		Menyerang ();
	}

	void Menyerang() 
	{
		Debug.Log ("Menyerang");
	}
}
