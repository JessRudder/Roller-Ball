using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	private float horiz;
	private float vert;
	private Rigidbody rb;

	[Range(400,900)] public int speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		horiz = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		vert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
//		transform.Translate (new Vector3 (horiz, 0, vert));
		rb.AddForce (Vector3.right * horiz);
		rb.AddForce (Vector3.forward * vert);

	}

	void OnTriggerEnter (Collider intruder) {
		if (intruder.tag == "Coin") {
			Destroy (intruder.gameObject);
		}
	}
//	void onTriggerEnter (Collision intruder) {
//		if (intruder.gameObject.tag == "Coin") {
//			Debug.Log ("Hey!  I'm a coin!");
//		}
//	}
}
