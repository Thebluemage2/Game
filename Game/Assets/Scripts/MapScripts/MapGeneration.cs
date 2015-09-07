using UnityEngine;
using System.Collections;

public class MapGeneration : MonoBehaviour {

	public GameObject[,] blocks;

	public GameObject baseBlock;

	public GameObject[,] Chunks;
	public GameObject Chunk;
	public int ChunkSize;

	public GameObject camera;

	public int mapWidth, mapHeight;

	// Use this for initialization
	void Start () {
		Chunks = new GameObject[mapWidth, mapHeight];
		//blocks = new GameObject[ChunkSize, ChunkSize];
		for(int x = 0; x < mapWidth; x++){
			for(int y = 0; y < mapHeight; y++){
				Chunks[x, y] = (GameObject)Instantiate(Chunk, new Vector2(x * 5.115f,y * 5.115f) , Quaternion.identity);
				Chunks[x, y].transform.parent = gameObject.transform;
			}
		}

		//Chunk = (GameObject)Instantiate(Chunk, Vector2.zero, Quaternion.identity);
		//Chunk.transform.parent = gameObject.transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		for(int x = 0; x < mapWidth; x++){
			for(int y = 0; y < mapHeight; y++){
				if(Chunks[x, y].transform.position.x - camera.transform.position.x > 25 || Chunks[x, y].transform.position.y - camera.transform.position.y > 15)
				{
					Chunks[x,y].SetActive(false);
				}
				else if(Chunks[x, y].transform.position.x - camera.transform.position.x < -25 || Chunks[x, y].transform.position.y - camera.transform.position.y < -15){
					Chunks[x,y].SetActive(false);
				}
				else
				{
					Chunks[x,y].SetActive(true);
				}
			}
		}
			
	}
}
