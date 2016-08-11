using UnityEngine;
using System.Collections;

public class LifttR : MonoBehaviour {
	public GameObject objetcs;
	private bool isRight = true;
	public float velocidade = 5f; 
	public float mxDelay;
	private float timeMove = 0f;

	public Transform vertexBegin;
	public Transform vertexLast;

	public bool isAlvo;

	private float mxDelayObjeto = 0.001f;
	private float timeObjeto = 10f;


	// Use this for initialization)
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Movimentar ();
		Behaviours ();

	}



	//vis o objeto
	void Behaviours(){

		if (isAlvo) {

			if (timeObjeto <= mxDelayObjeto) {


				timeObjeto += Time.deltaTime;

				Instantiate (objetcs, vertexBegin.position, objetcs.transform.rotation);
				print ("demais");
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


			if (isRight) {

				// go forward
				transform.Translate (-Vector2.left * velocidade * Time.deltaTime);
				// face forward
				transform.eulerAngles = new Vector2 (0, 0);

			} else {
				// go backwards
				transform.Translate (-Vector2.left * velocidade * Time.deltaTime);

				//face backwards
				transform.eulerAngles = new Vector2 (0, 180);



			}

		}
		else {

			isRight = !isRight;
			timeMove = 0;

		}



	}

}
