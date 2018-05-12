﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

	public Transform meta;
	private UnidadStats personaje;
	public bool mover;

	private Vector3 vectorPosicion;

	// Use this for initialization
	void Start () {
		vectorPosicion = meta.position;
		mover = true;
		personaje = GetComponent<UnidadStats>();
	}
	
	// Update is called once per frame
	void Update () {
		vectorPosicion = meta.position;

		if(meta.name == "Castillo Rojo" || meta.name == "Castillo Azul")
		{
			vectorPosicion = new Vector3 (transform.position.x, transform.position.y, meta.transform.position.z);
		}

		if(mover)
		{
//			transform.position = Vector3.MoveTowards (transform.position, meta.position, personaje.movimiento * Time.deltaTime);		
			transform.position = Vector3.MoveTowards (transform.position, vectorPosicion, personaje.movimiento * Time.deltaTime);		
			transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
			transform.LookAt(vectorPosicion);
			transform.Rotate (0,180f,0);
		}

		
	}
}
