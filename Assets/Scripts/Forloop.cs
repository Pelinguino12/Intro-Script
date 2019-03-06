using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forloop : MonoBehaviour {

	int[]numeros = new int[6] {10,20,30,40,50,60};
	// Use this for initializatio
	void Start () 
	{
		for (int i = 0;i<numeros.Length;i++)
	{
		Debug.Log(numeros[i]);
	}
	}
}
