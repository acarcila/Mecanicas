using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	private UnidadStats vidaCastilloRojo,vidaCastilloAzul;
	private TiempoControlador tiempo;
	private ConocerGanador ganador;

	void Start () {
		vidaCastilloRojo = GameObject.Find("Castillo Rojo").GetComponent<UnidadStats>();
		vidaCastilloAzul = GameObject.Find("Castillo Azul").GetComponent<UnidadStats>();
		ganador = GameObject.Find("Ganador").GetComponent<ConocerGanador>();
		tiempo = GameObject.Find("Time").GetComponent<TiempoControlador>();
	}
		
	// Update is called once per frame
	void Update () {
		if(tiempo.tiempo <= 0){
			ganador.bandera = true;
			cambiarPantalla();
		}
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

	public void cambiarPantalla(){
		SceneManager.LoadScene ("Fin");
	}
}
