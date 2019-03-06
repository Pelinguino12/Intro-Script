using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchcase : MonoBehaviour {

	public int vidas = 5;
	// Use this for initialization
	void Update () {
		switch(vidas)
		{
			case 0:
				Debug.Log("HAS PERDIDO");
				break;
			case 1:
				Debug.Log("ME QUEDA UNA VIDA");
				break;
			default:
				Debug.Log("ME QUEDAN VIDAS");
				break;
		}

	}
}
