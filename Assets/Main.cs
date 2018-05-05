using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	private UnidadStats vidaCastilloRojo,vidaCastilloAzul;


	void Start () {
		vidaCastilloRojo = GameObject.Find("Castillo Rojo").GetComponent<UnidadStats>();
		vidaCastilloAzul = GameObject.Find("Castillo Azul").GetComponent<UnidadStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string compararVida(){
		string ganador = "";
		if(vidaCastilloRojo.vida > vidaCastilloAzul.vida){
			 ganador = "Rojo";
		}
		if(vidaCastilloRojo.vida < vidaCastilloAzul.vida){
			 ganador = "Azul";
		}
		return ganador;
	}
}
