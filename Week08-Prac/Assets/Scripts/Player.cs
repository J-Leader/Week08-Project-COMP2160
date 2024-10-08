using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    static private Player instance;
    static public Player Instance {
        get {
            if (instance == null) {
                Debug.LogError("There is no Player instance in the scene.");
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
