using UnityEngine;
using System.Collections;

public class StoneThrow : MonoBehaviour {
	public Transform crosshair;
	public float speedModifier = 10;

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(new Vector2(crosshair.position.x * speedModifier, crosshair.position.y * speedModifier));
	}
	
	// Update is called once per frame
	void Update () {
	}
}