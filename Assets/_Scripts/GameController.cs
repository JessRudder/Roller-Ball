using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	private GameObject player;
	private GameObject coin;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		coin = GameObject.FindGameObjectWithTag ("Coin");
		this.transform.SetParent (player.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
