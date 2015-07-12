using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	public int value;

	// Use this for initialization
	void Start () {
		value = GetRandomNumber (0,20, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	private int GetRandomNumber(int max, int min, float probabilityPower = 1) {
		float randomFloat = Random.Range (0f, 1f);
		
		float result = Mathf.Floor(min + (max + 1 - min) * (Mathf.Pow(randomFloat, probabilityPower)));
		return (int) result;
	}
}