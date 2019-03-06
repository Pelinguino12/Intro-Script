using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : MonoBehaviour {
	private int velocidadMaxima = 120;
	private int velocidadMinima = 50;
	public int velocidadCoche = 80;
	public bool llueve = true;
	
	// Update is called once per frame
	void Update () {
		if(velocidadCoche >= velocidadMaxima)
		{
			Debug.Log("Velocidad máxima alcanzada");
		}
		if(velocidadCoche <= velocidadMinima)
		{
			Debug.Log("Velocidad mínima alcanzada");
		}
		if(velocidadCoche != 0)
		{
			Debug.Log("En marcha");
		}
		if(velocidadCoche == 0)
		{
			Debug.Log("En reposo");
		}
		if(velocidadCoche <= velocidadMinima || velocidadCoche >= velocidadMaxima)
		{
			Debug.Log("Límite alcanzado");
		}
		if(velocidadCoche >= 100 && llueve == true)
		{
			Debug.Log("Conduce con cuidado");
		}
		else
		{

		}
	}	
}
