using UnityEngine;
using System.Collections;

public class boton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void jugar (){
		Application.LoadLevel("Fase01");
	}

	public void salir(){
		Application.Quit ();
	}
}
