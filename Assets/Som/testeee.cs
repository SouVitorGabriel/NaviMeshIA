using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeee : MonoBehaviour {
    AudioSource ac;

    public int trilha;

    public AudioClip trilhaInicio;
    public AudioClip trilhaTexto;
    public AudioClip trilhaExploracao;
    public AudioClip trilhaCombate;

	// Use this for initialization
	void Start () {
        ac = this.GetComponent<AudioSource>();
        ac.clip = trilhaInicio;
        ac.Play();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
