using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float velocidade;

	public Transform player;
	private Animator animator;
	private Rigidbody2D rb;

	public bool isGrounded;
	public float force;

	public float jumpTime = 0.4f;
	public float jumpDelay = 0.4f;
	public bool jumped = false;
	public Transform Ground;
	public enum playerNumber {Player1, Player2}
	public playerNumber thisPlayer;
	private string horControl, jumpControl;


	private float shootingRate = 0.1f;
	private float shootCoolDown = 0.1f;
	public Transform spawnArm;
	public GameObject Arm;







	//public Manager manager;


	// Use this for initialization


	void Start () {
		//moviment player
		rb = gameObject.GetComponent<Rigidbody2D> ();
		animator = player.GetComponent<Animator> ();

		if (thisPlayer == playerNumber.Player1) {
			horControl = "Horizontal";
			jumpControl = "Jump";
		}

	

	}
	
	// Update is called once per frame
	void Update () {


	
		Movimentar();

		if (shootCoolDown > 0)
			shootCoolDown -= Time.deltaTime;

		if (Input.GetKey ("k")) {
			Fire ();
			shootCoolDown = shootingRate;
		}


	}


	void Fire ()
	{
		//Arm command para executar
		if (shootCoolDown <= 0f) {
			if (Arm != null) {
				var cloneArm = Instantiate (Arm, spawnArm.position, Quaternion.identity) as GameObject;
				cloneArm.transform.localScale = this.transform.localScale;
			}
		}
	
	}
	//Movimento no eixo X e Y
	void Movimentar()
	{


		//conf control
		isGrounded = Physics2D.Linecast (this.transform.position, Ground.position, 1 << LayerMask.NameToLayer ("Plataforma"));
		//animator.SetFloat ("run", Mathf.Abs (Input.GetAxis (horControl)));
		
		//control Horizontal
		if (Input.GetAxisRaw (horControl) > 0) {
			
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.localScale = new Vector3 (1.045858f, 1.045858f, 1.045858f);
			animator.SetInteger ("Run", 1);

		} else if (Input.GetAxisRaw (horControl) == 0) {
			animator.SetInteger ("Run", 0);

		
		}
			

	
			

		//control Horizontal
		if (Input.GetAxisRaw (horControl) < 0) {
			
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.localScale = new Vector3(-1.045858f, 1.045858f, 1.045858f);
			animator.SetInteger ("Run", 1);

		}

		else if (Input.GetAxisRaw (horControl) == 0) {
			animator.SetInteger ("Run", 0);


		}


		//control jump
		if (isGrounded && Input.GetButtonDown (jumpControl)) {
			
			rb.AddForce (transform.up * force);


	


		
}

}


}