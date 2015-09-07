using UnityEngine;
using System.Collections;

public class ChunkScript : MonoBehaviour {

	public GameObject[,] blocks;

	public GameObject[] trees;

	private GameObject tree;

	// Use this for initialization
	public GameObject baseBlock;

	public BlockScript blockS;

	public GameObject mainCamera;

	public int ChunkSize;

	void Start () {

		blocks = new GameObject[ChunkSize, ChunkSize];
		for(int x = 0; x < ChunkSize; x++){
			for(int y = 0; y < ChunkSize; y++){
				blocks[x, y] = (GameObject)Instantiate(baseBlock, new Vector2(x * 0.036f,y * 0.036f) , Quaternion.identity);
				blocks[x, y].transform.parent = gameObject.transform;
				blocks[x, y].transform.localPosition = new Vector2(x * 0.32f,y * 0.32f);
				//blockS = blocks[x,y].transform.gameObject.GetComponent<BlockScript>();
				//blockS.blockType = Random.Range(0,2);
			}
		}
		for(int x = 0; x < ChunkSize; x++){
			for(int y = 0; y < ChunkSize; y++){
				if(Random.Range (0,10) == 1)
				{
					Vector2 location;
					location = new Vector2(blocks[x,y].transform.position.x, blocks[x,y].transform.position.y + 0.17f);
					tree = (GameObject)Instantiate(trees[0], location, Quaternion.identity);
					tree.transform.parent = gameObject.transform;
			}
		}
	}

		mainCamera = GameObject.Find("Camera");
	}


	void Update(){



		/*
		if(((gameObject.transform.position.x - mainCamera.transform.position.x) >= 6) && ((gameObject.transform.position.y - mainCamera.transform.position.y) >= 6)){
			gameObject.SetActive(false);
			Debug.Log ("X: " + gameObject.transform.position.x + " " + mainCamera.transform.position.x);
			Debug.Log ("Y: " + gameObject.transform.position.y + " " + mainCamera.transform.position.y);
			Debug.Log ("Math: " + (gameObject.transform.position.x - mainCamera.transform.position.x));
		}
		else if(((gameObject.transform.position.x - mainCamera.transform.position.x) <= -6) && ((gameObject.transform.position.y - mainCamera.transform.position.y) <= -6)){
			gameObject.SetActive(false);
			Debug.Log ("X: " + gameObject.transform.position.x + " " + mainCamera.transform.position.x);
			Debug.Log ("Y: " + gameObject.transform.position.y + " " + mainCamera.transform.position.y);
			Debug.Log ("Math: " + (gameObject.transform.position.x - mainCamera.transform.position.x));
		}
		else{
			gameObject.SetActive(true);
		}
		*/



	}
}