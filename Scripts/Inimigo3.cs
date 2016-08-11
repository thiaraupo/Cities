using UnityEngine;
using System.Collections;

public class Inimigo3 : MonoBehaviour 
{
	public GameObject objetcs;
	private bool isLeft = true;
	public float velocidade = 5f; 
	public float mxDelay;
	private float timeMove = 0f;
	
	public Transform vertexBegin;
	public Transform vertexLast;
	
	public bool isAlvo;
	
	private float mxDelayObjeto = 0.001f;
	private float timeObjeto = 10f;

	public Transform spawnArm;
	public GameObject Arm;
	
	
	// Use this for initialization)
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Movimentar ();
		RayCasting ();
		Behaviours ();
		
	}
	
	void RayCasting() 
	{
		//vertex inicial e final script
		Debug.DrawLine (vertexBegin.position, vertexLast.position, Color.red);
		isAlvo = Physics2D.Linecast (vertexBegin.position, vertexLast.position, 
		                             1 << LayerMask.NameToLayer ("Player"));
		
	}
	
	//vis o objeto
	void Behaviours(){
		
		if (isAlvo) {
			
			if (timeObjeto <= mxDelayObjeto) {
				
				
				timeObjeto += Time.deltaTime;
				
				Instantiate (objetcs, vertexBegin.position, objetcs.transform.rotation);
			}
			
			
		} else {
			
			timeObjeto = 0;
			
			
		}
		
		
		
	}
	
	
	//mov do inimigo
	void Movimentar ()
	{
		
		timeMove += Time.deltaTime;
		
		if (timeMove <= mxDelay) {
			
			
			if (isLeft) {

				// go forward
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
				// face forward
				transform.eulerAngles = new Vector2 (0, 0);
				
			} else {
				// go backwards
				transform.Translate (-Vector2.right * velocidade * Time.deltaTime);

				//face backwards
				transform.eulerAngles = new Vector2 (0, 180);

				Debug.Log ("Jump and Destroy Enemy");

			}
			
		}
		else {
			
			isLeft = !isLeft;
			timeMove = 0;



			
		}
		
	}


	// Colisor Arm Player with Enemy
	void OnCollisionEnter2D(Collision2D colisor)
	{
		
		if(colisor.gameObject.tag == "Pedra") {
			
			Destroy(colisor.gameObject);
			
			Destroy(gameObject);
			
			
		}
	}
	
}
