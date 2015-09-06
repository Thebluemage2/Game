using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour {

	public int woodAmmount;
	public float sapAmmount;
	public PlayerScript playerscript;
	

	// Use this for initialization
	void Start () {
		GameObject test;
		test = GameObject.Find ("PlayerObject");
		playerscript = test.GetComponent<PlayerScript>();
		woodAmmount = Random.Range(3,7);
		sapAmmount = Random.Range (3.0f, 8.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		Debug.Log ("Debug");
		playerscript.wood += woodAmmount;
		playerscript.sap += sapAmmount;
		Destroy(transform.gameObject);
	}

	void OnMouseEnter(){
		playerscript.cursorType = 1;
	}

	void OnMouseExit(){
		playerscript.cursorType = 0;
	}


}
