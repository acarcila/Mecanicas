using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionGuerrero : MonoBehaviour {

	public Animator anim;
	private MovimientoPersonaje personaje;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		personaje = GetComponentInParent<MovimientoPersonaje> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(personaje.mover)
		{
			anim.Play ("Walk");
		}else{
			anim.Play ("Idle");
		}
	}
}
