using UnityEngine;
using System.Collections;

public class Pedra_Movement : MonoBehaviour {

	public float speed;



	
	// Update is called once per frame
	void Update () {

		transform.Translate (speed, 0, 0);

	}
}
