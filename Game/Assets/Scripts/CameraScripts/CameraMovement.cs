using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float speed = 5.0F;
	public float speedMultiplier = 1;
	public float normalSpeed = 5.0F;
	public float zoomSpeed = 1;
	public float CurrentZoom = 5;

	public GameObject FollowNPC;

	public Ray ray;
	public RaycastHit hit;

	public Material material;
	public Camera camera;
	public MeshRenderer render;

	public PlayerScript playerscript;

	public bool isFollowing;

	public bool canMove;

	private bool mouseControl;

	// Use this for initialization
	void Start () {
		camera.orthographicSize = CurrentZoom;
		GameObject test;
		test = GameObject.Find ("PlayerObject");
		playerscript = test.GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {

		if(!isFollowing && canMove){
			if(Input.GetKey ("d")){
				transform.Translate(Vector2.right * Time.deltaTime * speed * speedMultiplier, Space.World);
			}
			if(Input.GetKey ("a")){
				transform.Translate(Vector2.right * Time.deltaTime * -speed * speedMultiplier, Space.World);
			}
			if(Input.GetKey ("w")){
				transform.Translate(Vector2.up * Time.deltaTime * speed * speedMultiplier, Space.World);
			}
			if(Input.GetKey ("s")){
				transform.Translate(Vector2.up * Time.deltaTime * -speed * speedMultiplier, Space.World);
			}
			if(Input.GetMouseButtonDown(2)){
				mouseControl = true;
			}
			if(Input.GetMouseButtonUp (2)){
				mouseControl = false;
				playerscript.cursorType = 0;
			}
			if(mouseControl){
				//Debug.Log ("Hi");
				transform.Translate (Vector2.right * -0.25f * Input.GetAxis ("Mouse X"), Space.World);
				transform.Translate (Vector2.up * -0.25f * Input.GetAxis ("Mouse Y"), Space.World);
				playerscript.cursorType = 2;
			}
			//transform.Translate (Vector2.right * Input.GetAxis ("Mouse X") * 0.25f, Space.World);
		}
		else{
			gameObject.transform.position = new Vector3(FollowNPC.gameObject.transform.position.x,FollowNPC.gameObject.transform.position.y, -10);

		}

		if(canMove){
		CurrentZoom -= Input.GetAxis ("Mouse ScrollWheel") * Time.deltaTime * 50 * zoomSpeed;
		CurrentZoom = Mathf.Clamp (CurrentZoom, 1, 7);
		
		speedMultiplier = CurrentZoom / 3;
		
		camera.orthographicSize = CurrentZoom;
		}
		if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//print ("Bruh");
		}

		if(Physics.Raycast(ray, out hit)){
			if(hit.transform.gameObject is NPC){
				FollowNPC = hit.transform.gameObject;
				isFollowing = true;
			}
		}

	}
}