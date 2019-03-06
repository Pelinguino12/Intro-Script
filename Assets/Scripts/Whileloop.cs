using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whileloop : MonoBehaviour {

	int[] incrementDeSuma = new int[] {7,5,6,2};
	int resultado;
	int i = 0;
	// Use this for initialization
	void Start () 
	{
		do
		{
			resultado += incrementDeSuma[i];
			i++;
			Debug.Log(resultado);
		}while (i<4);
	}
}
