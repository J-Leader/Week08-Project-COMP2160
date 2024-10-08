using UnityEngine;
using System.Collections;

public class player2 : MonoBehaviour {
    static private player2 instance;
    static public player2 Instance {
        get {
            if (instance == null) {
                Debug.LogError("There is no player2 instance in the scene.");
            }
            return instance;
        }
    }
    public delegate void OnPickupEvent(int score);
    public event OnPickupEvent PickupEvent;

    public int totalScore = 0;

	public void OnTriggerEnter(Collider collider) {
        int pointsValue = collider.gameObject.GetComponent<CoinPickup>().pointsValue;
        totalScore += pointsValue;
        PickupEvent?.Invoke(pointsValue);
	}
}
