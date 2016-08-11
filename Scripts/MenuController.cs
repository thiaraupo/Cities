using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play ()
	{
		
		Application.LoadLevel ("Scene1");

		Debug.Log ("Change Scene");

	}

	public void Credits()
	{

		Application.LoadLevel ("Credits");

		Debug.Log ("Change Credits");

	}

	public void Exit()
	{

		Application.LoadLevel ("GameOver");

		Debug.Log ("Change GameOver");
	}

	public void Back()
	{

		Application.LoadLevel("Menu");

		Debug.Log ("Change Menu");
	}
}


