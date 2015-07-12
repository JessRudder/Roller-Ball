using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	private float horiz;
	private float vert;
	private Rigidbody rb;
	public int score = 0;
	public Text scoreText;


	[Range(400,900)] public int speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		scoreText.text = "Score: " + score;
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
			score += intruder.GetComponent<CoinScript>().value;
			scoreText.text = "Score: " + score;

		}
	}
}
