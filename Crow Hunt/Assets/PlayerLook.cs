using UnityEngine;
using System.Collections;

public class PlayerLook : MonoBehaviour {
	public Rigidbody2D stone;
	public Transform crosshair;
	public float speedModifier;

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame 
	void Update () {
		crosshair.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, -6)) / 3;

		if (Input.GetMouseButtonDown(0))
		{
			Rigidbody2D projectile = (Rigidbody2D)Instantiate(stone, new Vector3(this.transform.position.x,this.transform.position.y), Quaternion.identity);
			projectile.AddForce(new Vector2(crosshair.position.x - this.transform.position.x, crosshair.position.y - this.transform.position.y) * speedModifier);
		}
	}
}
