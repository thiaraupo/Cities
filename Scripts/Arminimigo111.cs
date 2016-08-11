using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Arminimigo111 : MonoBehaviour {

	public int point = 2;
	public float temMaxLife;
	public float temLife;

	//private LifePlayer life;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//destruir o fogo da cena
		temLife += Time.deltaTime;
		if (temLife >= temMaxLife) {

			Destroy (gameObject);
			temLife = 0;
		}
	}

	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Player") {

			//destruir vidas
			//life = GameObject.FindGameObjectWithTag ("LifePlaye").GetComponent<LifePlayer> () as LifePlayer;

			//if (life.LoseLife()) 
			//{
				Destroy (gameObject);


			} else {
				//gerenciador.GameOver

			}

		}

	}



