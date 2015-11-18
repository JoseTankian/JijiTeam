using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public float fuerzaSalto =200f;
	public float velocidad_pollo = 50f;
	Rigidbody2D rg; //se le puede dar el nombre que quieras, en este caso rg

	// Use this for initialization
	void Start () {
		rg= GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			if(Time.timeScale>=1)
			{
			salto();
			// Debug.Log("Estoy saltaandoo uo uoo"); //el punto siempre indica que se le da una funcion a lo que haya antes
			//GetComponent<Rigidbody2D>().AddForce (fuerzaSalto);// esto tambien se puede poner como: rg= GetComponent<Rigidbody2D>(); y despues rg.AddForce(fuerzaSalto);
			}
		}
		if(Input.GetKey(KeyCode.A)){
			mueve_izquierda();
		}

		if(Input.GetKey(KeyCode.D)){
			mueve_derecha();
		}
		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity;
	Debug.DrawLine(transform.position, new Vector3(transform.position.x+ velocidad.x,
		                                           transform.position.y + velocidad.y, transform.position.z));
	}
	
		void salto(){
			rg.AddForce(new Vector2 (0, fuerzaSalto));

		}
		
		void mueve_izquierda()
	{
		transform.localScale=(new Vector3(1,1,1));
		//rg.AddForce(new Vector2 (-(velocidad_pollo),0)); con esto lo que pasa esq a cada frame se le da esa velocidad y sale disparado
		rg.velocity=(new Vector2 (-(velocidad_pollo),rg.velocity.y)); //de esta forma la velocidad siempre sera constante, el rg.velocity.y es para q caiga a la vez que salta

	}
		void mueve_derecha()
	{
		transform.localScale=(new Vector3(-1,1,1));
		//rg.AddForce(new Vector2 (velocidad_pollo,0 ));
		rg.velocity=(new Vector2 (velocidad_pollo,rg.velocity.y));

		}



	}

