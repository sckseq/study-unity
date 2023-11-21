using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    private Transform _transform;
    private Animator _animator;
    private float _horizontal;
    private float _vertical;
    private Vector3 _velocity;
    private float _speed = 2f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
        _animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        _velocity = new Vector3(_horizontal, _rigidbody.velocity.y, _vertical).normalized;

        Debug.Log(_velocity.magnitude);
        if (_velocity.magnitude > 0.1f)
        {
            _animator.SetBool("walking", true);
        }
        else
        {
            _animator.SetBool("walking", false);
        }

        _rigidbody.velocity = _velocity * _speed;
    }
}