using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fruit : MonoBehaviour {


	public int scoreValue;
	private GameController gameController;


	// Use this for initialization
	void Start () 
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
			if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null) 
		{
			Debug.Log ("Cannot find 'GameController' script");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	//colisao da fruta
	void OnCollisionEnter2D(Collision2D coll){


	if (coll.gameObject.tag == "Player"){
		
			gameController.AddScore (scoreValue);
			Destroy (gameObject);


		
		

		}

}
}
