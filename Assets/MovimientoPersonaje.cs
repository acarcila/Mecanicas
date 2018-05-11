using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

	public Transform meta;
	private UnidadStats personaje;
	public bool mover;

	// Use this for initialization
	void Start () {
		mover = true;
		personaje = GetComponent<UnidadStats>();
	}
	
	// Update is called once per frame
	void Update () {
		if(mover)
		{
			switch(meta.name){
			case "Castillo Rojo":
				transform.Translate(-Vector3.forward * personaje.movimiento * Time.deltaTime);
				break;
			case "Castillo Azul":
				transform.Translate(-Vector3.forward * personaje.movimiento * Time.deltaTime);
				break;
			default:
				transform.position = Vector3.MoveTowards (transform.position, meta.position, personaje.movimiento * Time.deltaTime);		
				transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
				transform.LookAt(meta.position);
				transform.Rotate (0,180f,0);
				break;
			}
		}	
	}
}
