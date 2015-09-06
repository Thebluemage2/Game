using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

	public SpriteRenderer renderer;
	public Sprite[] blockTypes;
	public int blockType;

	//public int blockListBlock;

	// Use this for initialization
	void Start () {
		//blockTypes = new Sprite[10];
		blockType = Random.Range(0,2);
		//print (blockType);
		renderer.sprite = blockTypes[blockType];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
