using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem; // new input system namespace

public class PlayerMovement : MonoBehaviour
{
    public Animation PlayerAnimations;
    public float speed = 5f;
    public Rigidbody2D rb;

    public int playerHealth = 10;

    private InputAction movement;

    void Start()
    {
        movement = InputSystem.actions.FindAction("Move");
        PlayerAnimations = GetComponent<Animation>();
    }

    void FixedUpdate()
    {
        //waits for input
        Vector2 playerMovement = movement.ReadValue<Vector2>();

        rb.linearVelocity = playerMovement * speed;
    }

    public bool IsDead => playerHealth <= 0;
}