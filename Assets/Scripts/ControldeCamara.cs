using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldeCamara : MonoBehaviour {

    public GameObject Jugador;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - Jugador.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Jugador.transform.position + offset;
	}
}
