using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	private GameObject player;
	public GameObject coin;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");

		this.transform.SetParent (player.transform);

		for (var i = 0; i < 50; i++) {
			Instantiate(coin, new Vector3 (Random.Range (-96f,96f),2,Random.Range (-96f,96f)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
