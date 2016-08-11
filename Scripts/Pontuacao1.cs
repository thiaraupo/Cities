using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pontuacao1 : MonoBehaviour {

	public int score;
	public Text frutas;
	public float max_frutas2;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		frutas.text = "Frutas:  " + score;

	
	}

	void OnCollisionEnter2D(Collision2D coll){
	
		if (coll.gameObject.tag == "Frutas") {
		
			Destroy (coll.gameObject);
			score += 1;
		
		}


		if (coll.gameObject.tag == "Porta" && score == max_frutas2) {
				SceneManager.LoadScene ("Scene2");

		}
	}
}
