using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour {
    [SerializeField] private float walkSpeed = 5f;
	  private Rigidbody rb;
	  private PlayerInputs playerInputs;
    void Awake() {
		    playerInputs = new PlayerInputs();
		    playerInputs.KeyboardInputs.Enable();
	  }
    void Start() {
		    rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update() {
		    Vector3 velocity = rb.velocity;
        Vector2 inputAxis = playerInputs.KeyboardInputs.Movement.ReadValue<Vector2>();
        velocity.x = walkSpeed * inputAxis.x;
        velocity.z = walkSpeed * inputAxis.y;
		    rb.velocity = velocity;
    }
}
