using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float Jump_force;
	public Animator anim;
	public GameObject prefab;
	public Transform player;
	public float prefab_force;
	public GameObject spawn_position;
	private bool change1;




	// Use this for initialization
	void Start () {

		change1 = false;


	
	}
	
	// Update is called once per frame
	void Update () {

		Rigidbody2D Character = GetComponent<Rigidbody2D> ();

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed, 0, 0);
			//transform.localScale = new Vector3 (1, 1, 1);
			transform.localRotation = Quaternion.Euler(0, 0,0);
			anim.SetInteger ("Walk", 1);
		} else if (Input.GetKeyUp (KeyCode.D))
			anim.SetInteger ("Walk", 0);

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (speed, 0, 0);
			//transform.localScale = new Vector3 (-1, 1, 1);
			transform.localRotation = Quaternion.Euler(0, 180f,0);
			anim.SetInteger ("Walk", 1);
		} else if (Input.GetKeyUp (KeyCode.A))
			anim.SetInteger ("Walk", 0);


		if (change1 == false && Input.GetKeyDown (KeyCode.Space)) {
		
			Character.AddForce (transform.up * Jump_force);
			change1 = true;
		
		}
			


		if (Input.GetKeyDown (KeyCode.K)) {
		
			GameObject pedra = Instantiate (prefab, spawn_position.transform.position, spawn_position.transform.rotation) as GameObject;
			Destroy (pedra, 0.3f);

		}



	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Plataforma") {
		
			change1 = false;
		
		}
	
	}
}
