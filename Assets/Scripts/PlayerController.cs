using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    [SerializeField] private float moveSpeed;

    public UnityEvent OnDied;

    private Rigidbody2D rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Rotate();
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpPower;
    }

    private void Rotate()
    {
        transform.right = rb.velocity + Vector2.right * moveSpeed;
    }

    private void OnJump(InputValue value)
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnDied?.Invoke();
    }
}
