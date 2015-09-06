using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
	
	public float Health;
	public float MaxHealth;
	public float Temp;
	public float Hunger;
	public float MaxHunger;
	public float Comfort;
	public string Name;

	public bool canMove;

	//Stats
	public float Athletics;
	public float Smarts;
	public float Endurance;
	public float Agility;
	public float Perception;
	public float Stealth;
	public int SocietyRank;

	public SpriteRenderer spriterender;

	private float speed =  1;

	
	void Start () {
		//spriterender.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(canMove){
			if(Input.GetKey ("d")){
				transform.Translate(Vector2.right * Time.deltaTime * speed * Athletics, Space.World);
			}
			if(Input.GetKey ("a")){
				transform.Translate(Vector2.right * Time.deltaTime * -speed * Athletics, Space.World);
			}
			if(Input.GetKey ("w")){
				transform.Translate(Vector2.up * Time.deltaTime * speed * Athletics, Space.World);
			}
			if(Input.GetKey ("s")){
				transform.Translate(Vector2.up * Time.deltaTime * -speed * Athletics, Space.World);
			}
		}
	}
	
}
