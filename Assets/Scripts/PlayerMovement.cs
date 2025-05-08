using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
	public float moveSpeed = 5f;

    Vector2 moveDirection = Vector2.zero;
	public InputAction playerMovement;

   private void OnEnable()
   {
    playerMovement.Enable();
   }

   private void OnDisable()
   {
    playerMovement.Disable();
   }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
       // float verticalInput = Input.GetAxis("Vertical");
	    moveDirection = playerMovement.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
