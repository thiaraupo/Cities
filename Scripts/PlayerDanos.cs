using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDanos : MonoBehaviour {

	public GameObject coracao1;
	public GameObject coracao2;
	public GameObject coracao3;

	private int life = 3;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (life == 2)
			Destroy (coracao3);
		if (life == 1)
			Destroy (coracao2);
		if (life == 0) {
			Destroy (coracao1);
			SceneManager.LoadScene ("GameOver");
		
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){
	
		if (coll.gameObject.tag == "Inimigo3") {
		
			life -= 1;

		
		}
	
	}
}
