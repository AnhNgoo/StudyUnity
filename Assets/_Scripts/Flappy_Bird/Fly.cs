using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class Fly : MonoBehaviour
{
    [SerializeField] private float Speed = 1.5f;
    [SerializeField] private float RotationEulear = 10f;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * Speed;
        }
    }

    void FixedUpdate()
    {
        transform.rotation =  Quaternion.Euler(0, 0, rb.linearVelocity.y * RotationEulear);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.ins.CheckGameOver();
    }
}
