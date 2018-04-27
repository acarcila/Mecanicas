using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnidadStats : MonoBehaviour {

	public char tipo;
	public int vida;
	public int daño;
	public int movimiento;
	public int rango;
	public string unidadEnemiga;
	public Image healthBar;

	private float vidaInicial;

	// Use this for initialization
	void Start () {
		vidaInicial = vida;
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.fillAmount = vida / vidaInicial;
		if(vida < 0)
		{
			muerte();
		}
	}

	public void muerte(){
		this.gameObject.SetActive(false);
		Destroy (this.gameObject, 5);
	}
}
