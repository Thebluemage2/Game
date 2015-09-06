using UnityEngine;
using UnityEditor;
using System.Collections;

public class PlayerDebug : EditorWindow {

	private PlayerScript script;

	private int tab;

	// Use this for initialization
	void Start () {
	}

	[MenuItem("Window/Debug")]
	public static void ShowWindow(){
		EditorWindow.GetWindow (typeof(PlayerDebug));
	}

	void OnGUI(){
		GameObject test;
		test = GameObject.Find ("PlayerObject");
		script = test.GetComponent<PlayerScript>();

		tab = GUILayout.Toolbar (tab,new string[] {"Additions", "Subtraction", "Map"});
		switch(tab){
		case 0:
			GUILayout.Label ("Debug Menu",EditorStyles.boldLabel);
			GUILayout.Space (5);
			
			if(GUILayout.Button ("Add Wood", EditorStyles.miniButton)){
				script.wood += 5;
			}
			break;
		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}
