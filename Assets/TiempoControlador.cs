using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiempoControlador : MonoBehaviour {

	public float tiempoMaximo;
	public float tiempoMuerteSubita;
	public bool muerteSubita;

	private Text timer;
	private float segundos, minutos;
	private float tiempo;

	// Use this for initialization
	void Start () {
		timer = GetComponent<Text> ();
		tiempo = tiempoMaximo + 1f;
		muerteSubita = false;
	}
	
	// Update is called once per frame
	void Update () {
		contarTiempo ();
		if(tiempo <= tiempoMuerteSubita){
			muerteSubita = true;
		}
		if(tiempo <= 0){
			SceneManager.LoadScene ("Fin");
		}
	}

	private void contarTiempo(){
		tiempo -= Time.deltaTime;
		minutos = (int)(tiempo / 60f);
		segundos = (int)(tiempo % 60f);
		timer.text = minutos.ToString("00") + ":" + segundos.ToString("00");
	}
}
