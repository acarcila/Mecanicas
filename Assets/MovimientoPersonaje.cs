﻿using System.Collections;
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
			transform.position = Vector3.MoveTowards (transform.position, meta.position, personaje.movimiento * Time.deltaTime);		}

		
	}
}