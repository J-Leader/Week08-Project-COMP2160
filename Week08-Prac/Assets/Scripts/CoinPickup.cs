using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	[SerializeField] private LayerMask playerLayer;
	// private AudioSource sound;
	private bool isGone = false;
	public bool destroy = false;
	public int pointsValue = 5;

	public void Start() {
		// sound = gameObject.GetComponent<AudioSource>();
	}

	public void OnTriggerEnter(Collider collider) {
		if (isGone){
			return;
		}
		if (((1 << collider.gameObject.layer) & playerLayer.value) != 0) {
			// if (sound != null) {
			// 	sound.Play();
			// }
			MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
			renderer.enabled = false;
			isGone = true;
		}
	}

	public void OnTriggerExit(Collider collider) {
		if (((1 << collider.gameObject.layer) & playerLayer.value) != 0) {
			if(destroy) {
				Destroy(gameObject);
			}
		}
	}
}
