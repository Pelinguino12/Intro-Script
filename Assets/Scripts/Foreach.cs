using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour {

	string [] animales = new string [4] {"Serpiente","Tigre","Elefante","Gato"};
	// Use this for initialization
	void Start () {
		foreach(string animal in animales)
		{
			Debug.Log(animal);
		}
	}
}
