using UnityEngine;
using UnityEditor;
using System.Collections;

public class PlayerDebug : EditorWindow {

	private PlayerScript script;

	private int tab;

	private int tab2;


	private float toAdd;

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

		tab = GUILayout.Toolbar (tab,new string[] {"Resources", "Map", "UI"});
		switch(tab){
		case 0:
			GUILayout.Label ("Debug Menu",EditorStyles.boldLabel);
			GUILayout.Space (5);


			GUILayout.Label ("" + (int)toAdd,EditorStyles.label);
			toAdd = GUILayout.HorizontalSlider(toAdd,0,100,null);

			GUILayout.Space (10);

			tab2 = GUILayout.Toolbar (tab2,new string[] {"Minerals", "Food", "Materials", "Other..."});
			if(tab2 == 0)
			{
				if(GUILayout.Button ("Add Iron", EditorStyles.miniButton)){
					script.iron+= (int)toAdd;
				}
			}
			if(tab2 == 1)
			{
				if(GUILayout.Button ("Add Sap", EditorStyles.miniButton)){
					script.sap += toAdd;
				}
				GUILayout.Space (5);
				if(GUILayout.Button ("Add Water", EditorStyles.miniButton)){
					script.water += toAdd;
				}
			}
			if(tab2 == 2)
			{
				if(GUILayout.Button ("Add Stone", EditorStyles.miniButton)){
					script.stone += (int)toAdd;
				}
				if(GUILayout.Button ("Add Wood", EditorStyles.miniButton)){
					script.wood += (int)toAdd;
				}
			}


			break;
		}


	}

	// Update is called once per frame
	void Update () {
	
	}
}
