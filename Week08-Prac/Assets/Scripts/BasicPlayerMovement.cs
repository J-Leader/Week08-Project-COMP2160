using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour {
    [SerializeField] private float walkSpeed = 5f;
	  private Rigidbody2D rb2D;
	  private PlayerInputs playerInputs;
    void Awake() {
		    playerInputs = new PlayerInputs();
		    playerInputs.KeyboardInputs.Enable();
	  }
    void Start() {
		    rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update() {
		Vector2 velocity = rb2D.velocity;
        Vector2 inputAxis = playerInputs.KeyboardInputs.Movement.ReadValue<Vector2>();
        velocity.x = walkSpeed * inputAxis.x;
        velocity.y = walkSpeed * inputAxis.y;
		rb2D.velocity = velocity;
    }
}
