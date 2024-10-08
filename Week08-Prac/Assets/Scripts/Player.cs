using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public int totalScore = 0;

	public void Start() {

	}

	public void OnTriggerEnter(Collider collider) {
        int pointsValue = collider.gameObject.GetComponent<CoinPickup>().pointsValue;
        totalScore += pointsValue;
        //declare point scored
	}
}
