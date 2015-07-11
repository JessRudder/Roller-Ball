using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	private float horiz;
	private float vert;

	[Range(0,10)] public int speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		horiz = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		vert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		transform.Translate (new Vector3 (horiz, 0, vert));

	}
}
