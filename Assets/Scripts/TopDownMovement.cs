using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float speed = 5;
    private TopDownCharacterController _controller;

    private Vector2 _movementDirecettion = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirecettion);
    }
    private void Move(Vector2 direction)
    {
        _movementDirecettion = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        _rigidbody.velocity = direction;
        _animator.SetFloat("Speed", direction.magnitude);
    }
}
