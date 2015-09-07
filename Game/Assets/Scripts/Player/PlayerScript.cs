using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public string name;
	public Text houseName;

	public int stone;
	public int wood;
	public int iron;


	public float sap;
	public float water;

	public Text woodText;


	private Vector2 mouse;
	private int cursorw = 32;
	private int cursorh = 32;
	public Texture2D[] cursor;
	public int cursorType;
	
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		//woodText.text = "Wood: " + wood;
		mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
		Cursor.visible = false;
		houseName.text = name;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect(mouse.x,mouse.y,cursorw,cursorh),cursor[cursorType]);
	}
}
