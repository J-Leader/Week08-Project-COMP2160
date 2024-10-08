using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	[SerializeField] private LayerMask playerLayer;
	private AudioSource sound;
	private bool isGone = false;
	public bool destroy = false;

	public void Start() {
		sound = gameObject.GetComponent<AudioSource>();
	}

	public void OnTriggerEnter2D(Collider2D collider) {
		if (isGone){
			return;
		}
		if (((1 << collider.gameObject.layer) & playerLayer.value) != 0) {
			if (sound != null) {
				sound.Play();
			}
			SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
			renderer.enabled = false;
			isGone = true;
		}
	}

	public void OnTriggerExit2D(Collider2D collider) {
		if (((1 << collider.gameObject.layer) & playerLayer.value) != 0) {
			if(destroy) {
				Destroy(gameObject);
			}
		}
	}
}
